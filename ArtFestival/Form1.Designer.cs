namespace ArtFestival
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
            tabControlMain = new TabControl();
            tabPageMain = new TabPage();
            groupBoxDetails = new GroupBox();
            picEventImage = new PictureBox();
            labelEventName = new Label();
            labelEventDescription = new Label();
            labelEventTime = new Label();
            labelEventUsers = new Label();
            labelEventCategory = new Label();
            groupBoxView = new GroupBox();
            btnMainApplyFilter = new Button();
            cmbMainFilterCategory = new ComboBox();
            dtpMainFilterDate = new DateTimePicker();
            labelMainFilterCategory = new Label();
            labelMainFilterDate = new Label();
            lbMainEvents = new ListBox();
            tabPageEdit = new TabPage();
            groupBoxAdd = new GroupBox();
            labelAddTitle = new Label();
            txtAddTitle = new TextBox();
            labelAddDate = new Label();
            dtpAddDate = new DateTimePicker();
            labelAddDescription = new Label();
            txtAddDescription = new TextBox();
            labelAddCategory = new Label();
            cmbAddCategory = new ComboBox();
            labelAddParticipants = new Label();
            clbAddParticipants = new CheckedListBox();
            btnAddEvent = new Button();
            groupBoxEdit = new GroupBox();
            lbEditEvents = new ListBox();
            labelEditTitle = new Label();
            txtEditTitle = new TextBox();
            labelEditDate = new Label();
            dtpEditDate = new DateTimePicker();
            labelEditCategory = new Label();
            cmbEditCategory = new ComboBox();
            labelEditParticipants = new Label();
            clbEditParticipants = new CheckedListBox();
            btnEditSelected = new Button();
            btnSaveChanges = new Button();
            groupBoxDelete = new GroupBox();
            lbDeleteEvents = new ListBox();
            btnDelete = new Button();
            tabControlMain.SuspendLayout();
            tabPageMain.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEventImage).BeginInit();
            groupBoxView.SuspendLayout();
            tabPageEdit.SuspendLayout();
            groupBoxAdd.SuspendLayout();
            groupBoxEdit.SuspendLayout();
            groupBoxDelete.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageMain);
            tabControlMain.Controls.Add(tabPageEdit);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 600);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(groupBoxDetails);
            tabPageMain.Controls.Add(groupBoxView);
            tabPageMain.Location = new Point(4, 29);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(792, 567);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Главное меню";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Controls.Add(picEventImage);
            groupBoxDetails.Controls.Add(labelEventName);
            groupBoxDetails.Controls.Add(labelEventDescription);
            groupBoxDetails.Controls.Add(labelEventTime);
            groupBoxDetails.Controls.Add(labelEventUsers);
            groupBoxDetails.Controls.Add(labelEventCategory);
            groupBoxDetails.Location = new Point(392, 6);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(390, 562);
            groupBoxDetails.TabIndex = 1;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Детали события";
            // 
            // picEventImage
            // 
            picEventImage.BorderStyle = BorderStyle.FixedSingle;
            picEventImage.Location = new Point(10, 25);
            picEventImage.Name = "picEventImage";
            picEventImage.Size = new Size(146, 150);
            picEventImage.TabIndex = 0;
            picEventImage.TabStop = false;
            // 
            // labelEventName
            // 
            labelEventName.AutoSize = true;
            labelEventName.Location = new Point(10, 190);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(143, 20);
            labelEventName.TabIndex = 1;
            labelEventName.Text = "Название события:";
            // 
            // labelEventDescription
            // 
            labelEventDescription.AutoSize = true;
            labelEventDescription.Location = new Point(10, 220);
            labelEventDescription.Name = "labelEventDescription";
            labelEventDescription.Size = new Size(82, 20);
            labelEventDescription.TabIndex = 2;
            labelEventDescription.Text = "Описание:";
            // 
            // labelEventTime
            // 
            labelEventTime.AutoSize = true;
            labelEventTime.Location = new Point(10, 250);
            labelEventTime.Name = "labelEventTime";
            labelEventTime.Size = new Size(146, 20);
            labelEventTime.TabIndex = 3;
            labelEventTime.Text = "Время проведения:";
            // 
            // labelEventUsers
            // 
            labelEventUsers.AutoSize = true;
            labelEventUsers.Location = new Point(10, 280);
            labelEventUsers.Name = "labelEventUsers";
            labelEventUsers.Size = new Size(84, 20);
            labelEventUsers.TabIndex = 4;
            labelEventUsers.Text = "Участники:";
            // 
            // labelEventCategory
            // 
            labelEventCategory.AutoSize = true;
            labelEventCategory.Location = new Point(10, 310);
            labelEventCategory.Name = "labelEventCategory";
            labelEventCategory.Size = new Size(84, 20);
            labelEventCategory.TabIndex = 5;
            labelEventCategory.Text = "Категория:";
            // 
            // groupBoxView
            // 
            groupBoxView.Controls.Add(btnMainApplyFilter);
            groupBoxView.Controls.Add(cmbMainFilterCategory);
            groupBoxView.Controls.Add(dtpMainFilterDate);
            groupBoxView.Controls.Add(labelMainFilterCategory);
            groupBoxView.Controls.Add(labelMainFilterDate);
            groupBoxView.Controls.Add(lbMainEvents);
            groupBoxView.Location = new Point(6, 6);
            groupBoxView.Name = "groupBoxView";
            groupBoxView.Size = new Size(380, 562);
            groupBoxView.TabIndex = 0;
            groupBoxView.TabStop = false;
            groupBoxView.Text = "События и фильтрация";
            // 
            // btnMainApplyFilter
            // 
            btnMainApplyFilter.Location = new Point(254, 17);
            btnMainApplyFilter.Name = "btnMainApplyFilter";
            btnMainApplyFilter.Size = new Size(120, 30);
            btnMainApplyFilter.TabIndex = 4;
            btnMainApplyFilter.Text = "Применить фильтр";
            btnMainApplyFilter.UseVisualStyleBackColor = true;
            // 
            // cmbMainFilterCategory
            // 
            cmbMainFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMainFilterCategory.FormattingEnabled = true;
            cmbMainFilterCategory.Location = new Point(100, 50);
            cmbMainFilterCategory.Name = "cmbMainFilterCategory";
            cmbMainFilterCategory.Size = new Size(150, 28);
            cmbMainFilterCategory.TabIndex = 3;
            // 
            // dtpMainFilterDate
            // 
            dtpMainFilterDate.CustomFormat = "dd.MM.yyyy";
            dtpMainFilterDate.Format = DateTimePickerFormat.Custom;
            dtpMainFilterDate.Location = new Point(70, 20);
            dtpMainFilterDate.Name = "dtpMainFilterDate";
            dtpMainFilterDate.Size = new Size(120, 27);
            dtpMainFilterDate.TabIndex = 1;
            // 
            // labelMainFilterCategory
            // 
            labelMainFilterCategory.AutoSize = true;
            labelMainFilterCategory.Location = new Point(10, 53);
            labelMainFilterCategory.Name = "labelMainFilterCategory";
            labelMainFilterCategory.Size = new Size(84, 20);
            labelMainFilterCategory.TabIndex = 2;
            labelMainFilterCategory.Text = "Категория:";

            // 
            // labelMainFilterDate
            // 
            labelMainFilterDate.AutoSize = true;
            labelMainFilterDate.Location = new Point(10, 25);
            labelMainFilterDate.Name = "labelMainFilterDate";
            labelMainFilterDate.Size = new Size(44, 20);
            labelMainFilterDate.TabIndex = 0;
            labelMainFilterDate.Text = "Дата:";
            // 
            // lbMainEvents
            // 
            lbMainEvents.FormattingEnabled = true;
            lbMainEvents.Location = new Point(10, 80);
            lbMainEvents.Name = "lbMainEvents";
            lbMainEvents.Size = new Size(350, 464);
            lbMainEvents.TabIndex = 5;

            // 
            // tabPageEdit
            // 
            tabPageEdit.Controls.Add(groupBoxAdd);
            tabPageEdit.Controls.Add(groupBoxEdit);
            tabPageEdit.Controls.Add(groupBoxDelete);
            tabPageEdit.Location = new Point(4, 29);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Padding = new Padding(3);
            tabPageEdit.Size = new Size(792, 567);
            tabPageEdit.TabIndex = 1;
            tabPageEdit.Text = "Редактирование";
            tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdd
            // 
            groupBoxAdd.Controls.Add(labelAddTitle);
            groupBoxAdd.Controls.Add(txtAddTitle);
            groupBoxAdd.Controls.Add(labelAddDate);
            groupBoxAdd.Controls.Add(dtpAddDate);
            groupBoxAdd.Controls.Add(labelAddDescription);
            groupBoxAdd.Controls.Add(txtAddDescription);
            groupBoxAdd.Controls.Add(labelAddCategory);
            groupBoxAdd.Controls.Add(cmbAddCategory);
            groupBoxAdd.Controls.Add(labelAddParticipants);
            groupBoxAdd.Controls.Add(clbAddParticipants);
            groupBoxAdd.Controls.Add(btnAddEvent);
            groupBoxAdd.Location = new Point(6, 6);
            groupBoxAdd.Name = "groupBoxAdd";
            groupBoxAdd.Size = new Size(300, 350);
            groupBoxAdd.TabIndex = 0;
            groupBoxAdd.TabStop = false;
            groupBoxAdd.Text = "Добавление события";
            // 
            // labelAddTitle
            // 
            labelAddTitle.AutoSize = true;
            labelAddTitle.Location = new Point(10, 25);
            labelAddTitle.Name = "labelAddTitle";
            labelAddTitle.Size = new Size(80, 20);
            labelAddTitle.TabIndex = 0;
            labelAddTitle.Text = "Название:";
            // 
            // txtAddTitle
            // 
            txtAddTitle.Location = new Point(100, 22);
            txtAddTitle.Name = "txtAddTitle";
            txtAddTitle.Size = new Size(180, 27);
            txtAddTitle.TabIndex = 1;
            // 
            // labelAddDate
            // 
            labelAddDate.AutoSize = true;
            labelAddDate.Location = new Point(10, 55);
            labelAddDate.Name = "labelAddDate";
            labelAddDate.Size = new Size(44, 20);
            labelAddDate.TabIndex = 2;
            labelAddDate.Text = "Дата:";
            // 
            // dtpAddDate
            // 
            dtpAddDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpAddDate.Format = DateTimePickerFormat.Custom;
            dtpAddDate.Location = new Point(100, 50);
            dtpAddDate.Name = "dtpAddDate";
            dtpAddDate.Size = new Size(180, 27);
            dtpAddDate.TabIndex = 3;
            // 
            // labelAddDescription
            // 
            labelAddDescription.AutoSize = true;
            labelAddDescription.Location = new Point(10, 85);
            labelAddDescription.Name = "labelAddDescription";
            labelAddDescription.Size = new Size(82, 20);
            labelAddDescription.TabIndex = 4;
            labelAddDescription.Text = "Описание:";
            // 
            // txtAddDescription
            // 
            txtAddDescription.Location = new Point(100, 80);
            txtAddDescription.Multiline = true;
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(180, 60);
            txtAddDescription.TabIndex = 5;
            // 
            // labelAddCategory
            // 
            labelAddCategory.AutoSize = true;
            labelAddCategory.Location = new Point(10, 155);
            labelAddCategory.Name = "labelAddCategory";
            labelAddCategory.Size = new Size(84, 20);
            labelAddCategory.TabIndex = 6;
            labelAddCategory.Text = "Категория:";
            // 
            // cmbAddCategory
            // 
            cmbAddCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddCategory.FormattingEnabled = true;
            cmbAddCategory.Location = new Point(100, 150);
            cmbAddCategory.Name = "cmbAddCategory";
            cmbAddCategory.Size = new Size(180, 28);
            cmbAddCategory.TabIndex = 7;
            // 
            // labelAddParticipants
            // 
            labelAddParticipants.AutoSize = true;
            labelAddParticipants.Location = new Point(10, 185);
            labelAddParticipants.Name = "labelAddParticipants";
            labelAddParticipants.Size = new Size(84, 20);
            labelAddParticipants.TabIndex = 8;
            labelAddParticipants.Text = "Участники:";
            // 
            // clbAddParticipants
            // 
            clbAddParticipants.FormattingEnabled = true;
            clbAddParticipants.Location = new Point(100, 185);
            clbAddParticipants.Name = "clbAddParticipants";
            clbAddParticipants.Size = new Size(180, 92);
            clbAddParticipants.TabIndex = 9;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(100, 290);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(180, 30);
            btnAddEvent.TabIndex = 10;
            btnAddEvent.Text = "Добавить";
            btnAddEvent.UseVisualStyleBackColor = true;

            // 
            // groupBoxEdit
            // 
            groupBoxEdit.Controls.Add(lbEditEvents);
            groupBoxEdit.Controls.Add(labelEditTitle);
            groupBoxEdit.Controls.Add(txtEditTitle);
            groupBoxEdit.Controls.Add(labelEditDate);
            groupBoxEdit.Controls.Add(dtpEditDate);
            groupBoxEdit.Controls.Add(labelEditCategory);
            groupBoxEdit.Controls.Add(cmbEditCategory);
            groupBoxEdit.Controls.Add(labelEditParticipants);
            groupBoxEdit.Controls.Add(clbEditParticipants);
            groupBoxEdit.Controls.Add(btnEditSelected);
            groupBoxEdit.Controls.Add(btnSaveChanges);
            groupBoxEdit.Location = new Point(312, 6);
            groupBoxEdit.Name = "groupBoxEdit";
            groupBoxEdit.Size = new Size(472, 350);
            groupBoxEdit.TabIndex = 1;
            groupBoxEdit.TabStop = false;
            groupBoxEdit.Text = "Редактирование события";
            // 
            // lbEditEvents
            // 
            lbEditEvents.FormattingEnabled = true;
            lbEditEvents.Location = new Point(10, 20);
            lbEditEvents.Name = "lbEditEvents";
            lbEditEvents.Size = new Size(456, 64);
            lbEditEvents.TabIndex = 0;
            // 
            // labelEditTitle
            // 
            labelEditTitle.AutoSize = true;
            labelEditTitle.Location = new Point(10, 115);
            labelEditTitle.Name = "labelEditTitle";
            labelEditTitle.Size = new Size(80, 20);
            labelEditTitle.TabIndex = 1;
            labelEditTitle.Text = "Название:";
            // 
            // txtEditTitle
            // 
            txtEditTitle.Location = new Point(100, 112);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.Size = new Size(366, 27);
            txtEditTitle.TabIndex = 2;
            // 
            // labelEditDate
            // 
            labelEditDate.AutoSize = true;
            labelEditDate.Location = new Point(10, 145);
            labelEditDate.Name = "labelEditDate";
            labelEditDate.Size = new Size(44, 20);
            labelEditDate.TabIndex = 3;
            labelEditDate.Text = "Дата:";
            // 
            // dtpEditDate
            // 
            dtpEditDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpEditDate.Format = DateTimePickerFormat.Custom;
            dtpEditDate.Location = new Point(100, 140);
            dtpEditDate.Name = "dtpEditDate";
            dtpEditDate.Size = new Size(366, 27);
            dtpEditDate.TabIndex = 4;
            // 
            // labelEditCategory
            // 
            labelEditCategory.AutoSize = true;
            labelEditCategory.Location = new Point(10, 175);
            labelEditCategory.Name = "labelEditCategory";
            labelEditCategory.Size = new Size(84, 20);
            labelEditCategory.TabIndex = 5;
            labelEditCategory.Text = "Категория:";
            // 
            // cmbEditCategory
            // 
            cmbEditCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditCategory.FormattingEnabled = true;
            cmbEditCategory.Location = new Point(100, 170);
            cmbEditCategory.Name = "cmbEditCategory";
            cmbEditCategory.Size = new Size(366, 28);
            cmbEditCategory.TabIndex = 6;
            // 
            // labelEditParticipants
            // 
            labelEditParticipants.AutoSize = true;
            labelEditParticipants.Location = new Point(10, 205);
            labelEditParticipants.Name = "labelEditParticipants";
            labelEditParticipants.Size = new Size(84, 20);
            labelEditParticipants.TabIndex = 7;
            labelEditParticipants.Text = "Участники:";
            // 
            // clbEditParticipants
            // 
            clbEditParticipants.FormattingEnabled = true;
            clbEditParticipants.Location = new Point(100, 205);
            clbEditParticipants.Name = "clbEditParticipants";
            clbEditParticipants.Size = new Size(366, 48);
            clbEditParticipants.TabIndex = 8;
            // 
            // btnEditSelected
            // 
            btnEditSelected.Location = new Point(10, 280);
            btnEditSelected.Name = "btnEditSelected";
            btnEditSelected.Size = new Size(130, 30);
            btnEditSelected.TabIndex = 9;
            btnEditSelected.Text = "Редактировать выбранное событие";
            btnEditSelected.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(160, 280);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(130, 30);
            btnSaveChanges.TabIndex = 10;
            btnSaveChanges.Text = "Сохранить изменения";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // groupBoxDelete
            // 
            groupBoxDelete.Controls.Add(lbDeleteEvents);
            groupBoxDelete.Controls.Add(btnDelete);
            groupBoxDelete.Location = new Point(6, 362);
            groupBoxDelete.Name = "groupBoxDelete";
            groupBoxDelete.Size = new Size(772, 200);
            groupBoxDelete.TabIndex = 2;
            groupBoxDelete.TabStop = false;
            groupBoxDelete.Text = "Удаление события";
            // 
            // lbDeleteEvents
            // 
            lbDeleteEvents.FormattingEnabled = true;
            lbDeleteEvents.Location = new Point(10, 20);
            lbDeleteEvents.Name = "lbDeleteEvents";
            lbDeleteEvents.Size = new Size(730, 124);
            lbDeleteEvents.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(466, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "Менеджер событий";
            tabControlMain.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEventImage).EndInit();
            groupBoxView.ResumeLayout(false);
            groupBoxView.PerformLayout();
            tabPageEdit.ResumeLayout(false);
            groupBoxAdd.ResumeLayout(false);
            groupBoxAdd.PerformLayout();
            groupBoxEdit.ResumeLayout(false);
            groupBoxEdit.PerformLayout();
            groupBoxDelete.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Label labelEventUsers;
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
