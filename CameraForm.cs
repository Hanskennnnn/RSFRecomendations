using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.EntityFrameworkCore;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    /// <summary>
    /// Форма для камеры
    /// </summary>
    public partial class CameraForm : Form
    {
        private Logger Log;

        /// <summary>
        /// Пользователь 
        /// </summary>
        public UserModel User { get; set; }

        private readonly MyDBContext db;

        private AdditionalMethodsClass additionalMethods;

        private VideoCaptureDevice videoSource;

        public CameraForm(UserModel user)
        {
            InitializeComponent();
            InitializeCamera();

            User = user;
            Log = LogManager.GetCurrentClassLogger();
            additionalMethods = new AdditionalMethodsClass();
            db = new MyDBContext();

            Log.Info("Переход к форме камеры");
        }

        private void InitializeCamera()
        {
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show(Properties.Resources.EmptyCamera);
                Log.Warn(Properties.Resources.EmptyCameraLog);

                this.Close();
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
        }

        private async void pictureBoxToAddPhoto_Click(object sender, EventArgs e)
        {
            await db.Users.
                Where(c => c.Login == User.Login)
                .ExecuteUpdateAsync(s =>
                s.SetProperty(c => c.Image, additionalMethods.ImageToBytes(pictureBoxPhoto.Image)));

            await db.SaveChangesAsync();

            MessageBox.Show(Properties.Resources.SuccessfulAddPhoto);
            Log.Info(Properties.Resources.SuccessfulAddPhotoLog);

            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var frame = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxPhoto.Image = frame;
        }
    }
}
