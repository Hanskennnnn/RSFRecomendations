using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.picEventImage = new System.Windows.Forms.PictureBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.labelEventParticipants = new System.Windows.Forms.Label();
            this.labelEventCategory = new System.Windows.Forms.Label();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.btnMainApplyFilter = new System.Windows.Forms.Button();
            this.cmbMainFilterCategory = new System.Windows.Forms.ComboBox();
            this.dtpMainFilterDate = new System.Windows.Forms.DateTimePicker();
            this.labelMainFilterCategory = new System.Windows.Forms.Label();
            this.labelMainFilterDate = new System.Windows.Forms.Label();
            this.lbMainEvents = new System.Windows.Forms.ListBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.labelAddTitle = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.labelAddDate = new System.Windows.Forms.Label();
            this.dtpAddDate = new System.Windows.Forms.DateTimePicker();
            this.labelAddDescription = new System.Windows.Forms.Label();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.labelAddParticipants = new System.Windows.Forms.Label();
            this.clbAddParticipants = new System.Windows.Forms.CheckedListBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.lbEditEvents = new System.Windows.Forms.ListBox();
            this.labelEditTitle = new System.Windows.Forms.Label();
            this.txtEditTitle = new System.Windows.Forms.TextBox();
            this.labelEditDate = new System.Windows.Forms.Label();
            this.dtpEditDate = new System.Windows.Forms.DateTimePicker();
            this.labelEditCategory = new System.Windows.Forms.Label();
            this.cmbEditCategory = new System.Windows.Forms.ComboBox();
            this.labelEditParticipants = new System.Windows.Forms.Label();
            this.clbEditParticipants = new System.Windows.Forms.CheckedListBox();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.lbDeleteEvents = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventImage)).BeginInit();
            this.groupBoxView.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageEdit);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 600);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBoxDetails);
            this.tabPageMain.Controls.Add(this.groupBoxView);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(792, 571);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главное меню";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.picEventImage);
            this.groupBoxDetails.Controls.Add(this.labelEventName);
            this.groupBoxDetails.Controls.Add(this.labelEventDescription);
            this.groupBoxDetails.Controls.Add(this.labelEventTime);
            this.groupBoxDetails.Controls.Add(this.labelEventParticipants);
            this.groupBoxDetails.Controls.Add(this.labelEventCategory);
            this.groupBoxDetails.Location = new System.Drawing.Point(392, 6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(390, 562);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Детали события";
            // 
            // picEventImage
            // 
            this.picEventImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEventImage.Location = new System.Drawing.Point(10, 25);
            this.picEventImage.Name = "picEventImage";
            this.picEventImage.Size = new System.Drawing.Size(146, 150);
            this.picEventImage.TabIndex = 0;
            this.picEventImage.TabStop = false;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(10, 190);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(133, 16);
            this.labelEventName.TabIndex = 1;
            this.labelEventName.Text = "Название события:";
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.AutoSize = true;
            this.labelEventDescription.Location = new System.Drawing.Point(10, 220);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(75, 16);
            this.labelEventDescription.TabIndex = 2;
            this.labelEventDescription.Text = "Описание:";
            // 
            // labelEventTime
            // 
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Location = new System.Drawing.Point(10, 250);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(133, 16);
            this.labelEventTime.TabIndex = 3;
            this.labelEventTime.Text = "Время проведения:";
            // 
            // labelEventParticipants
            // 
            this.labelEventParticipants.AutoSize = true;
            this.labelEventParticipants.Location = new System.Drawing.Point(10, 280);
            this.labelEventParticipants.Name = "labelEventParticipants";
            this.labelEventParticipants.Size = new System.Drawing.Size(80, 16);
            this.labelEventParticipants.TabIndex = 4;
            this.labelEventParticipants.Text = "Участники:";
            // 
            // labelEventCategory
            // 
            this.labelEventCategory.AutoSize = true;
            this.labelEventCategory.Location = new System.Drawing.Point(10, 310);
            this.labelEventCategory.Name = "labelEventCategory";
            this.labelEventCategory.Size = new System.Drawing.Size(78, 16);
            this.labelEventCategory.TabIndex = 5;
            this.labelEventCategory.Text = "Категория:";
            // 
            // groupBoxView
            // 
            this.groupBoxView.Controls.Add(this.btnMainApplyFilter);
            this.groupBoxView.Controls.Add(this.cmbMainFilterCategory);
            this.groupBoxView.Controls.Add(this.dtpMainFilterDate);
            this.groupBoxView.Controls.Add(this.labelMainFilterCategory);
            this.groupBoxView.Controls.Add(this.labelMainFilterDate);
            this.groupBoxView.Controls.Add(this.lbMainEvents);
            this.groupBoxView.Location = new System.Drawing.Point(6, 6);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(380, 562);
            this.groupBoxView.TabIndex = 0;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "События и фильтрация";
            // 
            // btnMainApplyFilter
            // 
            this.btnMainApplyFilter.Location = new System.Drawing.Point(254, 17);
            this.btnMainApplyFilter.Name = "btnMainApplyFilter";
            this.btnMainApplyFilter.Size = new System.Drawing.Size(120, 30);
            this.btnMainApplyFilter.TabIndex = 4;
            this.btnMainApplyFilter.Text = "Применить фильтр";
            this.btnMainApplyFilter.UseVisualStyleBackColor = true;
            // 
            // cmbMainFilterCategory
            // 
            this.cmbMainFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainFilterCategory.FormattingEnabled = true;
            this.cmbMainFilterCategory.Location = new System.Drawing.Point(100, 50);
            this.cmbMainFilterCategory.Name = "cmbMainFilterCategory";
            this.cmbMainFilterCategory.Size = new System.Drawing.Size(150, 24);
            this.cmbMainFilterCategory.TabIndex = 3;
            // 
            // dtpMainFilterDate
            // 
            this.dtpMainFilterDate.CustomFormat = "dd.MM.yyyy";
            this.dtpMainFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMainFilterDate.Location = new System.Drawing.Point(70, 20);
            this.dtpMainFilterDate.Name = "dtpMainFilterDate";
            this.dtpMainFilterDate.Size = new System.Drawing.Size(120, 22);
            this.dtpMainFilterDate.TabIndex = 1;
            // 
            // labelMainFilterCategory
            // 
            this.labelMainFilterCategory.AutoSize = true;
            this.labelMainFilterCategory.Location = new System.Drawing.Point(10, 53);
            this.labelMainFilterCategory.Name = "labelMainFilterCategory";
            this.labelMainFilterCategory.Size = new System.Drawing.Size(78, 16);
            this.labelMainFilterCategory.TabIndex = 2;
            this.labelMainFilterCategory.Text = "Категория:";
            // 
            // labelMainFilterDate
            // 
            this.labelMainFilterDate.AutoSize = true;
            this.labelMainFilterDate.Location = new System.Drawing.Point(10, 25);
            this.labelMainFilterDate.Name = "labelMainFilterDate";
            this.labelMainFilterDate.Size = new System.Drawing.Size(42, 16);
            this.labelMainFilterDate.TabIndex = 0;
            this.labelMainFilterDate.Text = "Дата:";
            // 
            // lbMainEvents
            // 
            this.lbMainEvents.FormattingEnabled = true;
            this.lbMainEvents.ItemHeight = 16;
            this.lbMainEvents.Location = new System.Drawing.Point(10, 80);
            this.lbMainEvents.Name = "lbMainEvents";
            this.lbMainEvents.Size = new System.Drawing.Size(350, 452);
            this.lbMainEvents.TabIndex = 5;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.groupBoxAdd);
            this.tabPageEdit.Controls.Add(this.groupBoxEdit);
            this.tabPageEdit.Controls.Add(this.groupBoxDelete);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(792, 571);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "Редактирование";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.labelAddTitle);
            this.groupBoxAdd.Controls.Add(this.txtAddTitle);
            this.groupBoxAdd.Controls.Add(this.labelAddDate);
            this.groupBoxAdd.Controls.Add(this.dtpAddDate);
            this.groupBoxAdd.Controls.Add(this.labelAddDescription);
            this.groupBoxAdd.Controls.Add(this.txtAddDescription);
            this.groupBoxAdd.Controls.Add(this.labelAddCategory);
            this.groupBoxAdd.Controls.Add(this.cmbAddCategory);
            this.groupBoxAdd.Controls.Add(this.labelAddParticipants);
            this.groupBoxAdd.Controls.Add(this.clbAddParticipants);
            this.groupBoxAdd.Controls.Add(this.btnAddEvent);
            this.groupBoxAdd.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(300, 350);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление события";
            // 
            // labelAddTitle
            // 
            this.labelAddTitle.AutoSize = true;
            this.labelAddTitle.Location = new System.Drawing.Point(10, 25);
            this.labelAddTitle.Name = "labelAddTitle";
            this.labelAddTitle.Size = new System.Drawing.Size(76, 16);
            this.labelAddTitle.TabIndex = 0;
            this.labelAddTitle.Text = "Название:";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(100, 22);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(180, 22);
            this.txtAddTitle.TabIndex = 1;
            // 
            // labelAddDate
            // 
            this.labelAddDate.AutoSize = true;
            this.labelAddDate.Location = new System.Drawing.Point(10, 55);
            this.labelAddDate.Name = "labelAddDate";
            this.labelAddDate.Size = new System.Drawing.Size(42, 16);
            this.labelAddDate.TabIndex = 2;
            this.labelAddDate.Text = "Дата:";
            // 
            // dtpAddDate
            // 
            this.dtpAddDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpAddDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddDate.Location = new System.Drawing.Point(100, 50);
            this.dtpAddDate.Name = "dtpAddDate";
            this.dtpAddDate.Size = new System.Drawing.Size(180, 22);
            this.dtpAddDate.TabIndex = 3;
            // 
            // labelAddDescription
            // 
            this.labelAddDescription.AutoSize = true;
            this.labelAddDescription.Location = new System.Drawing.Point(10, 85);
            this.labelAddDescription.Name = "labelAddDescription";
            this.labelAddDescription.Size = new System.Drawing.Size(75, 16);
            this.labelAddDescription.TabIndex = 4;
            this.labelAddDescription.Text = "Описание:";
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(100, 80);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(180, 60);
            this.txtAddDescription.TabIndex = 5;
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(10, 155);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(78, 16);
            this.labelAddCategory.TabIndex = 6;
            this.labelAddCategory.Text = "Категория:";
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(100, 150);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(180, 24);
            this.cmbAddCategory.TabIndex = 7;
            // 
            // labelAddParticipants
            // 
            this.labelAddParticipants.AutoSize = true;
            this.labelAddParticipants.Location = new System.Drawing.Point(10, 185);
            this.labelAddParticipants.Name = "labelAddParticipants";
            this.labelAddParticipants.Size = new System.Drawing.Size(80, 16);
            this.labelAddParticipants.TabIndex = 8;
            this.labelAddParticipants.Text = "Участники:";
            // 
            // clbAddParticipants
            // 
            this.clbAddParticipants.FormattingEnabled = true;
            this.clbAddParticipants.Location = new System.Drawing.Point(100, 185);
            this.clbAddParticipants.Name = "clbAddParticipants";
            this.clbAddParticipants.Size = new System.Drawing.Size(180, 89);
            this.clbAddParticipants.TabIndex = 9;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(100, 290);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(180, 30);
            this.btnAddEvent.TabIndex = 10;
            this.btnAddEvent.Text = "Добавить";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.lbEditEvents);
            this.groupBoxEdit.Controls.Add(this.labelEditTitle);
            this.groupBoxEdit.Controls.Add(this.txtEditTitle);
            this.groupBoxEdit.Controls.Add(this.labelEditDate);
            this.groupBoxEdit.Controls.Add(this.dtpEditDate);
            this.groupBoxEdit.Controls.Add(this.labelEditCategory);
            this.groupBoxEdit.Controls.Add(this.cmbEditCategory);
            this.groupBoxEdit.Controls.Add(this.labelEditParticipants);
            this.groupBoxEdit.Controls.Add(this.clbEditParticipants);
            this.groupBoxEdit.Controls.Add(this.btnEditSelected);
            this.groupBoxEdit.Controls.Add(this.btnSaveChanges);
            this.groupBoxEdit.Location = new System.Drawing.Point(312, 6);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(472, 350);
            this.groupBoxEdit.TabIndex = 1;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактирование события";
            // 
            // lbEditEvents
            // 
            this.lbEditEvents.FormattingEnabled = true;
            this.lbEditEvents.ItemHeight = 16;
            this.lbEditEvents.Location = new System.Drawing.Point(10, 20);
            this.lbEditEvents.Name = "lbEditEvents";
            this.lbEditEvents.Size = new System.Drawing.Size(456, 52);
            this.lbEditEvents.TabIndex = 0;
            // 
            // labelEditTitle
            // 
            this.labelEditTitle.AutoSize = true;
            this.labelEditTitle.Location = new System.Drawing.Point(10, 115);
            this.labelEditTitle.Name = "labelEditTitle";
            this.labelEditTitle.Size = new System.Drawing.Size(76, 16);
            this.labelEditTitle.TabIndex = 1;
            this.labelEditTitle.Text = "Название:";
            // 
            // txtEditTitle
            // 
            this.txtEditTitle.Location = new System.Drawing.Point(100, 112);
            this.txtEditTitle.Name = "txtEditTitle";
            this.txtEditTitle.Size = new System.Drawing.Size(366, 22);
            this.txtEditTitle.TabIndex = 2;
            // 
            // labelEditDate
            // 
            this.labelEditDate.AutoSize = true;
            this.labelEditDate.Location = new System.Drawing.Point(10, 145);
            this.labelEditDate.Name = "labelEditDate";
            this.labelEditDate.Size = new System.Drawing.Size(42, 16);
            this.labelEditDate.TabIndex = 3;
            this.labelEditDate.Text = "Дата:";
            // 
            // dtpEditDate
            // 
            this.dtpEditDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditDate.Location = new System.Drawing.Point(100, 140);
            this.dtpEditDate.Name = "dtpEditDate";
            this.dtpEditDate.Size = new System.Drawing.Size(366, 22);
            this.dtpEditDate.TabIndex = 4;
            // 
            // labelEditCategory
            // 
            this.labelEditCategory.AutoSize = true;
            this.labelEditCategory.Location = new System.Drawing.Point(10, 175);
            this.labelEditCategory.Name = "labelEditCategory";
            this.labelEditCategory.Size = new System.Drawing.Size(78, 16);
            this.labelEditCategory.TabIndex = 5;
            this.labelEditCategory.Text = "Категория:";
            // 
            // cmbEditCategory
            // 
            this.cmbEditCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCategory.FormattingEnabled = true;
            this.cmbEditCategory.Location = new System.Drawing.Point(100, 170);
            this.cmbEditCategory.Name = "cmbEditCategory";
            this.cmbEditCategory.Size = new System.Drawing.Size(366, 24);
            this.cmbEditCategory.TabIndex = 6;
            // 
            // labelEditParticipants
            // 
            this.labelEditParticipants.AutoSize = true;
            this.labelEditParticipants.Location = new System.Drawing.Point(10, 205);
            this.labelEditParticipants.Name = "labelEditParticipants";
            this.labelEditParticipants.Size = new System.Drawing.Size(80, 16);
            this.labelEditParticipants.TabIndex = 7;
            this.labelEditParticipants.Text = "Участники:";
            // 
            // clbEditParticipants
            // 
            this.clbEditParticipants.FormattingEnabled = true;
            this.clbEditParticipants.Location = new System.Drawing.Point(100, 205);
            this.clbEditParticipants.Name = "clbEditParticipants";
            this.clbEditParticipants.Size = new System.Drawing.Size(366, 38);
            this.clbEditParticipants.TabIndex = 8;
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Location = new System.Drawing.Point(10, 280);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(130, 30);
            this.btnEditSelected.TabIndex = 9;
            this.btnEditSelected.Text = "Редактировать выбранное событие";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(160, 280);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(130, 30);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.lbDeleteEvents);
            this.groupBoxDelete.Controls.Add(this.btnDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(6, 362);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(772, 200);
            this.groupBoxDelete.TabIndex = 2;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Удаление события";
            // 
            // lbDeleteEvents
            // 
            this.lbDeleteEvents.FormattingEnabled = true;
            this.lbDeleteEvents.ItemHeight = 16;
            this.lbDeleteEvents.Location = new System.Drawing.Point(10, 20);
            this.lbDeleteEvents.Name = "lbDeleteEvents";
            this.lbDeleteEvents.Size = new System.Drawing.Size(730, 116);
            this.lbDeleteEvents.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(466, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(280, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Менеджер событий";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventImage)).EndInit();
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxView.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageEdit;
        // Вкладка "Главное меню"
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.Label labelMainFilterDate;
        private System.Windows.Forms.DateTimePicker dtpMainFilterDate;
        private System.Windows.Forms.Label labelMainFilterCategory;
        private System.Windows.Forms.ComboBox cmbMainFilterCategory;
        private System.Windows.Forms.Button btnMainApplyFilter;
        private System.Windows.Forms.ListBox lbMainEvents;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.PictureBox picEventImage;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelEventDescription;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label labelEventParticipants;
        private System.Windows.Forms.Label labelEventCategory;
        // Вкладка "Редактирование" – группы как в предыдущем примере
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label labelAddTitle;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label labelAddDate;
        private System.Windows.Forms.DateTimePicker dtpAddDate;
        private System.Windows.Forms.Label labelAddDescription;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label labelAddCategory;
        private System.Windows.Forms.ComboBox cmbAddCategory;
        private System.Windows.Forms.Label labelAddParticipants;
        private System.Windows.Forms.CheckedListBox clbAddParticipants;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.ListBox lbEditEvents;
        private System.Windows.Forms.Label labelEditTitle;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.Label labelEditDate;
        private System.Windows.Forms.DateTimePicker dtpEditDate;
        private System.Windows.Forms.Label labelEditCategory;
        private System.Windows.Forms.ComboBox cmbEditCategory;
        private System.Windows.Forms.Label labelEditParticipants;
        private System.Windows.Forms.CheckedListBox clbEditParticipants;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.ListBox lbDeleteEvents;
        private System.Windows.Forms.Button btnDelete;
    }
}
