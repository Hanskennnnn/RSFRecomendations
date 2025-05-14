namespace RSFRecomendations
{
    partial class CameraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxPhoto = new PictureBox();
            pictureBoxToAddPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxToAddPhoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(0, 0);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(957, 493);
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // pictureBoxToAddPhoto
            // 
            pictureBoxToAddPhoto.Image = Properties.Resources.camera_icon1;
            pictureBoxToAddPhoto.Location = new Point(443, 430);
            pictureBoxToAddPhoto.Name = "pictureBoxToAddPhoto";
            pictureBoxToAddPhoto.Size = new Size(72, 63);
            pictureBoxToAddPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxToAddPhoto.TabIndex = 1;
            pictureBoxToAddPhoto.TabStop = false;
            pictureBoxToAddPhoto.Click += pictureBoxToAddPhoto_Click;
            // 
            // CameraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 489);
            Controls.Add(pictureBoxToAddPhoto);
            Controls.Add(pictureBoxPhoto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CameraForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Камера";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxToAddPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPhoto;
        private PictureBox pictureBoxToAddPhoto;
    }
}