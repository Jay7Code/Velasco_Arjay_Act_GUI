namespace Velasco_Arjay_Act_GUI
{
    partial class EditForm
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
            NameLabel = new Label();
            NameTextBox = new TextBox();
            AgeLabel = new Label();
            AgeTextBox = new TextBox();
            AddressLabel = new Label();
            AddressTextBox = new TextBox();
            ContactNumberLabel = new Label();
            ContactNumberTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            CourseLabel = new Label();
            CourseComboBox = new ComboBox();
            YearLabel = new Label();
            YearComboBox = new ComboBox();
            ParentNameLabel = new Label();
            ParentNameTextBox = new TextBox();
            ParentContactLabel = new Label();
            ParentContactTextBox = new TextBox();
            HobbiesLabel = new Label();
            HobbiesTextBox = new TextBox();
            NicknameLabel = new Label();
            NicknameTextBox = new TextBox();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 11F);
            NameLabel.Location = new Point(50, 58);
            NameLabel.Margin = new Padding(5, 0, 5, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(76, 30);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(250, 59);
            NameTextBox.Margin = new Padding(5, 6, 5, 6);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(331, 31);
            NameTextBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Segoe UI", 11F);
            AgeLabel.Location = new Point(50, 115);
            AgeLabel.Margin = new Padding(5, 0, 5, 0);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(57, 30);
            AgeLabel.TabIndex = 2;
            AgeLabel.Text = "Age:";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(250, 117);
            AgeTextBox.Margin = new Padding(5, 6, 5, 6);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(81, 31);
            AgeTextBox.TabIndex = 2;
            AgeTextBox.KeyPress += AgeTextBox_KeyPress;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 11F);
            AddressLabel.Location = new Point(50, 173);
            AddressLabel.Margin = new Padding(5, 0, 5, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(96, 30);
            AddressLabel.TabIndex = 4;
            AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(250, 174);
            AddressTextBox.Margin = new Padding(5, 6, 5, 6);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(331, 31);
            AddressTextBox.TabIndex = 3;
            // 
            // ContactNumberLabel
            // 
            ContactNumberLabel.AutoSize = true;
            ContactNumberLabel.Font = new Font("Segoe UI", 11F);
            ContactNumberLabel.Location = new Point(50, 231);
            ContactNumberLabel.Margin = new Padding(5, 0, 5, 0);
            ContactNumberLabel.Name = "ContactNumberLabel";
            ContactNumberLabel.Size = new Size(178, 30);
            ContactNumberLabel.TabIndex = 6;
            ContactNumberLabel.Text = "Contact Number:";
            // 
            // ContactNumberTextBox
            // 
            ContactNumberTextBox.Location = new Point(250, 232);
            ContactNumberTextBox.Margin = new Padding(5, 6, 5, 6);
            ContactNumberTextBox.Name = "ContactNumberTextBox";
            ContactNumberTextBox.Size = new Size(247, 31);
            ContactNumberTextBox.TabIndex = 4;
            ContactNumberTextBox.KeyPress += ContactNumberTextBox_KeyPress;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 11F);
            EmailLabel.Location = new Point(50, 288);
            EmailLabel.Margin = new Padding(5, 0, 5, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(69, 30);
            EmailLabel.TabIndex = 8;
            EmailLabel.Text = "Email:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(250, 290);
            EmailTextBox.Margin = new Padding(5, 6, 5, 6);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(331, 31);
            EmailTextBox.TabIndex = 5;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 11F);
            CourseLabel.Location = new Point(50, 346);
            CourseLabel.Margin = new Padding(5, 0, 5, 0);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(86, 30);
            CourseLabel.TabIndex = 10;
            CourseLabel.Text = "Course:";
            // 
            // CourseComboBox
            // 
            CourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Location = new Point(250, 347);
            CourseComboBox.Margin = new Padding(5, 6, 5, 6);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(197, 33);
            CourseComboBox.TabIndex = 6;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Font = new Font("Segoe UI", 11F);
            YearLabel.Location = new Point(50, 404);
            YearLabel.Margin = new Padding(5, 0, 5, 0);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(59, 30);
            YearLabel.TabIndex = 12;
            YearLabel.Text = "Year:";
            // 
            // YearComboBox
            // 
            YearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Location = new Point(250, 405);
            YearComboBox.Margin = new Padding(5, 6, 5, 6);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(197, 33);
            YearComboBox.TabIndex = 7;
            // 
            // ParentNameLabel
            // 
            ParentNameLabel.AutoSize = true;
            ParentNameLabel.Font = new Font("Segoe UI", 11F);
            ParentNameLabel.Location = new Point(50, 462);
            ParentNameLabel.Margin = new Padding(5, 0, 5, 0);
            ParentNameLabel.Name = "ParentNameLabel";
            ParentNameLabel.Size = new Size(143, 30);
            ParentNameLabel.TabIndex = 14;
            ParentNameLabel.Text = "Parent Name:";
            // 
            // ParentNameTextBox
            // 
            ParentNameTextBox.Location = new Point(250, 463);
            ParentNameTextBox.Margin = new Padding(5, 6, 5, 6);
            ParentNameTextBox.Name = "ParentNameTextBox";
            ParentNameTextBox.Size = new Size(331, 31);
            ParentNameTextBox.TabIndex = 8;
            // 
            // ParentContactLabel
            // 
            ParentContactLabel.AutoSize = true;
            ParentContactLabel.Font = new Font("Segoe UI", 11F);
            ParentContactLabel.Location = new Point(50, 519);
            ParentContactLabel.Margin = new Padding(5, 0, 5, 0);
            ParentContactLabel.Name = "ParentContactLabel";
            ParentContactLabel.Size = new Size(159, 30);
            ParentContactLabel.TabIndex = 16;
            ParentContactLabel.Text = "Parent Contact:";
            // 
            // ParentContactTextBox
            // 
            ParentContactTextBox.Location = new Point(250, 520);
            ParentContactTextBox.Margin = new Padding(5, 6, 5, 6);
            ParentContactTextBox.Name = "ParentContactTextBox";
            ParentContactTextBox.Size = new Size(247, 31);
            ParentContactTextBox.TabIndex = 9;
            ParentContactTextBox.KeyPress += ParentContactTextBox_KeyPress;
            // 
            // HobbiesLabel
            // 
            HobbiesLabel.AutoSize = true;
            HobbiesLabel.Font = new Font("Segoe UI", 11F);
            HobbiesLabel.Location = new Point(50, 577);
            HobbiesLabel.Margin = new Padding(5, 0, 5, 0);
            HobbiesLabel.Name = "HobbiesLabel";
            HobbiesLabel.Size = new Size(99, 30);
            HobbiesLabel.TabIndex = 18;
            HobbiesLabel.Text = "Hobbies:";
            // 
            // HobbiesTextBox
            // 
            HobbiesTextBox.Location = new Point(250, 578);
            HobbiesTextBox.Margin = new Padding(5, 6, 5, 6);
            HobbiesTextBox.Name = "HobbiesTextBox";
            HobbiesTextBox.Size = new Size(331, 31);
            HobbiesTextBox.TabIndex = 10;
            // 
            // NicknameLabel
            // 
            NicknameLabel.AutoSize = true;
            NicknameLabel.Font = new Font("Segoe UI", 11F);
            NicknameLabel.Location = new Point(50, 635);
            NicknameLabel.Margin = new Padding(5, 0, 5, 0);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(114, 30);
            NicknameLabel.TabIndex = 20;
            NicknameLabel.Text = "Nickname:";
            // 
            // NicknameTextBox
            // 
            NicknameTextBox.Location = new Point(250, 636);
            NicknameTextBox.Margin = new Padding(5, 6, 5, 6);
            NicknameTextBox.Name = "NicknameTextBox";
            NicknameTextBox.Size = new Size(331, 31);
            NicknameTextBox.TabIndex = 11;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(250, 724);
            SaveBtn.Margin = new Padding(5, 6, 5, 6);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(125, 44);
            SaveBtn.TabIndex = 12;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 865);
            Controls.Add(SaveBtn);
            Controls.Add(NicknameTextBox);
            Controls.Add(NicknameLabel);
            Controls.Add(HobbiesTextBox);
            Controls.Add(HobbiesLabel);
            Controls.Add(ParentContactTextBox);
            Controls.Add(ParentContactLabel);
            Controls.Add(ParentNameTextBox);
            Controls.Add(ParentNameLabel);
            Controls.Add(YearComboBox);
            Controls.Add(YearLabel);
            Controls.Add(CourseComboBox);
            Controls.Add(CourseLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(ContactNumberTextBox);
            Controls.Add(ContactNumberLabel);
            Controls.Add(AddressTextBox);
            Controls.Add(AddressLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Margin = new Padding(5, 6, 5, 6);
            Name = "EditForm";
            Text = "Edit Page";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private StudentForm _studentForm;

        public EditForm(StudentForm studentForm)
        {
            InitializeComponent();
            _studentForm = studentForm;

            // Populate Course and Year dropdowns
            CourseComboBox.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });
            YearComboBox.Items.AddRange(new string[] { "First", "Second", "Third", "Fourth" });

            // Load current user profile data
            LoadUserProfile();
        }



        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label ParentNameLabel;
        private System.Windows.Forms.TextBox ParentNameTextBox;
        private System.Windows.Forms.Label ParentContactLabel;
        private System.Windows.Forms.TextBox ParentContactTextBox;
        private System.Windows.Forms.Label HobbiesLabel;
        private System.Windows.Forms.TextBox HobbiesTextBox;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.Button SaveBtn;
    }
}