namespace Velasco_Arjay_Act_GUI
{
    partial class StudentForm
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
            StudentPictureBox = new PictureBox();
            AddImageBtn = new Button();
            ChangeImageBtn = new Button();
            StudentNameLabel = new Label();
            NameLabel = new Label();
            AgeLabel = new Label();
            StudentAgeLabel = new Label();
            AddressLabel = new Label();
            StudentAddressLabel = new Label();
            ContactLabel = new Label();
            StudentContactLabel = new Label();
            EmailLabel = new Label();
            StudentEmailLabel = new Label();
            CourseYearLabel = new Label();
            StudentCourseYearLabel = new Label();
            ParentNameLbl = new Label();
            ParentNameLabel = new Label();
            ParentContactLbl = new Label();
            ParentContactLabel = new Label();
            HobbiesLbl = new Label();
            HobbiesLabel = new Label();
            NicknameLbl = new Label();
            NicknameLabel = new Label();
            EditUpdateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // StudentPictureBox
            // 
            StudentPictureBox.BorderStyle = BorderStyle.FixedSingle;
            StudentPictureBox.Location = new Point(37, 47);
            StudentPictureBox.Margin = new Padding(4, 5, 4, 5);
            StudentPictureBox.Name = "StudentPictureBox";
            StudentPictureBox.Size = new Size(228, 301);
            StudentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            StudentPictureBox.TabIndex = 0;
            StudentPictureBox.TabStop = false;
            // 
            // AddImageBtn
            // 
            AddImageBtn.Location = new Point(36, 362);
            AddImageBtn.Margin = new Padding(4, 5, 4, 5);
            AddImageBtn.Name = "AddImageBtn";
            AddImageBtn.Size = new Size(229, 60);
            AddImageBtn.TabIndex = 1;
            AddImageBtn.Text = "Add Image";
            AddImageBtn.UseVisualStyleBackColor = true;
            AddImageBtn.Click += AddImageBtn_Click;
            // 
            // ChangeImageBtn
            // 
            ChangeImageBtn.Location = new Point(36, 432);
            ChangeImageBtn.Margin = new Padding(4, 5, 4, 5);
            ChangeImageBtn.Name = "ChangeImageBtn";
            ChangeImageBtn.Size = new Size(229, 53);
            ChangeImageBtn.TabIndex = 2;
            ChangeImageBtn.Text = "Change Image";
            ChangeImageBtn.UseVisualStyleBackColor = true;
            ChangeImageBtn.Click += ChangeImageBtn_Click;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Font = new Font("Microsoft Sans Serif", 13F);
            StudentNameLabel.Location = new Point(496, 62);
            StudentNameLabel.Margin = new Padding(4, 0, 4, 0);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(169, 30);
            StudentNameLabel.TabIndex = 3;
            StudentNameLabel.Text = "StudentName";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 13F);
            NameLabel.Location = new Point(291, 68);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(89, 30);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Microsoft Sans Serif", 13F);
            AgeLabel.Location = new Point(291, 100);
            AgeLabel.Margin = new Padding(4, 0, 4, 0);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(65, 30);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Age:";
            // 
            // StudentAgeLabel
            // 
            StudentAgeLabel.AutoSize = true;
            StudentAgeLabel.Font = new Font("Microsoft Sans Serif", 13F);
            StudentAgeLabel.Location = new Point(496, 100);
            StudentAgeLabel.Margin = new Padding(4, 0, 4, 0);
            StudentAgeLabel.Name = "StudentAgeLabel";
            StudentAgeLabel.Size = new Size(145, 30);
            StudentAgeLabel.TabIndex = 6;
            StudentAgeLabel.Text = "StudentAge";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Microsoft Sans Serif", 13F);
            AddressLabel.Location = new Point(291, 132);
            AddressLabel.Margin = new Padding(4, 0, 4, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(114, 30);
            AddressLabel.TabIndex = 7;
            AddressLabel.Text = "Address:";
            // 
            // StudentAddressLabel
            // 
            StudentAddressLabel.AutoSize = true;
            StudentAddressLabel.Font = new Font("Microsoft Sans Serif", 13F);
            StudentAddressLabel.Location = new Point(496, 130);
            StudentAddressLabel.Margin = new Padding(4, 0, 4, 0);
            StudentAddressLabel.Name = "StudentAddressLabel";
            StudentAddressLabel.Size = new Size(194, 30);
            StudentAddressLabel.TabIndex = 8;
            StudentAddressLabel.Text = "StudentAddress";
            // 
            // ContactLabel
            // 
            ContactLabel.AutoSize = true;
            ContactLabel.Font = new Font("Microsoft Sans Serif", 13F);
            ContactLabel.Location = new Point(291, 162);
            ContactLabel.Margin = new Padding(4, 0, 4, 0);
            ContactLabel.Name = "ContactLabel";
            ContactLabel.Size = new Size(108, 30);
            ContactLabel.TabIndex = 9;
            ContactLabel.Text = "Contact:";
            // 
            // StudentContactLabel
            // 
            StudentContactLabel.AutoSize = true;
            StudentContactLabel.Font = new Font("Microsoft Sans Serif", 13F);
            StudentContactLabel.Location = new Point(496, 162);
            StudentContactLabel.Margin = new Padding(4, 0, 4, 0);
            StudentContactLabel.Name = "StudentContactLabel";
            StudentContactLabel.Size = new Size(188, 30);
            StudentContactLabel.TabIndex = 10;
            StudentContactLabel.Text = "StudentContact";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Microsoft Sans Serif", 13F);
            EmailLabel.Location = new Point(291, 193);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(85, 30);
            EmailLabel.TabIndex = 11;
            EmailLabel.Text = "Email:";
            // 
            // StudentEmailLabel
            // 
            StudentEmailLabel.AutoSize = true;
            StudentEmailLabel.Font = new Font("Microsoft Sans Serif", 13F);
            StudentEmailLabel.Location = new Point(496, 193);
            StudentEmailLabel.Margin = new Padding(4, 0, 4, 0);
            StudentEmailLabel.Name = "StudentEmailLabel";
            StudentEmailLabel.Size = new Size(165, 30);
            StudentEmailLabel.TabIndex = 12;
            StudentEmailLabel.Text = "StudentEmail";
            // 
            // CourseYearLabel
            // 
            CourseYearLabel.AutoSize = true;
            CourseYearLabel.Font = new Font("Microsoft Sans Serif", 13F);
            CourseYearLabel.Location = new Point(291, 225);
            CourseYearLabel.Margin = new Padding(4, 0, 4, 0);
            CourseYearLabel.Name = "CourseYearLabel";
            CourseYearLabel.Size = new Size(170, 30);
            CourseYearLabel.TabIndex = 13;
            CourseYearLabel.Text = "Course & Year:";
            // 
            // StudentCourseYearLabel
            // 
            StudentCourseYearLabel.AutoSize = true;
            StudentCourseYearLabel.Font = new Font("Microsoft Sans Serif", 13F);
            StudentCourseYearLabel.Location = new Point(496, 225);
            StudentCourseYearLabel.Margin = new Padding(4, 0, 4, 0);
            StudentCourseYearLabel.Name = "StudentCourseYearLabel";
            StudentCourseYearLabel.Size = new Size(236, 30);
            StudentCourseYearLabel.TabIndex = 14;
            StudentCourseYearLabel.Text = "StudentCourseYear";
            // 
            // ParentNameLbl
            // 
            ParentNameLbl.AutoSize = true;
            ParentNameLbl.Font = new Font("Microsoft Sans Serif", 13F);
            ParentNameLbl.Location = new Point(291, 257);
            ParentNameLbl.Margin = new Padding(4, 0, 4, 0);
            ParentNameLbl.Name = "ParentNameLbl";
            ParentNameLbl.Size = new Size(171, 30);
            ParentNameLbl.TabIndex = 15;
            ParentNameLbl.Text = "Parent Name:";
            // 
            // ParentNameLabel
            // 
            ParentNameLabel.AutoSize = true;
            ParentNameLabel.Font = new Font("Microsoft Sans Serif", 13F);
            ParentNameLabel.Location = new Point(496, 257);
            ParentNameLabel.Margin = new Padding(4, 0, 4, 0);
            ParentNameLabel.Name = "ParentNameLabel";
            ParentNameLabel.Size = new Size(157, 30);
            ParentNameLabel.TabIndex = 16;
            ParentNameLabel.Text = "ParentName";
            // 
            // ParentContactLbl
            // 
            ParentContactLbl.AutoSize = true;
            ParentContactLbl.Font = new Font("Microsoft Sans Serif", 13F);
            ParentContactLbl.Location = new Point(291, 288);
            ParentContactLbl.Margin = new Padding(4, 0, 4, 0);
            ParentContactLbl.Name = "ParentContactLbl";
            ParentContactLbl.Size = new Size(190, 30);
            ParentContactLbl.TabIndex = 17;
            ParentContactLbl.Text = "Parent Contact:";
            // 
            // ParentContactLabel
            // 
            ParentContactLabel.AutoSize = true;
            ParentContactLabel.Font = new Font("Microsoft Sans Serif", 13F);
            ParentContactLabel.Location = new Point(496, 288);
            ParentContactLabel.Margin = new Padding(4, 0, 4, 0);
            ParentContactLabel.Name = "ParentContactLabel";
            ParentContactLabel.Size = new Size(176, 30);
            ParentContactLabel.TabIndex = 18;
            ParentContactLabel.Text = "ParentContact";
            // 
            // HobbiesLbl
            // 
            HobbiesLbl.AutoSize = true;
            HobbiesLbl.Font = new Font("Microsoft Sans Serif", 13F);
            HobbiesLbl.Location = new Point(291, 318);
            HobbiesLbl.Margin = new Padding(4, 0, 4, 0);
            HobbiesLbl.Name = "HobbiesLbl";
            HobbiesLbl.Size = new Size(114, 30);
            HobbiesLbl.TabIndex = 19;
            HobbiesLbl.Text = "Hobbies:";
            // 
            // HobbiesLabel
            // 
            HobbiesLabel.AutoSize = true;
            HobbiesLabel.Font = new Font("Microsoft Sans Serif", 13F);
            HobbiesLabel.Location = new Point(496, 318);
            HobbiesLabel.Margin = new Padding(4, 0, 4, 0);
            HobbiesLabel.Name = "HobbiesLabel";
            HobbiesLabel.Size = new Size(107, 30);
            HobbiesLabel.TabIndex = 20;
            HobbiesLabel.Text = "Hobbies";
            // 
            // NicknameLbl
            // 
            NicknameLbl.AutoSize = true;
            NicknameLbl.Font = new Font("Microsoft Sans Serif", 13F);
            NicknameLbl.Location = new Point(291, 350);
            NicknameLbl.Margin = new Padding(4, 0, 4, 0);
            NicknameLbl.Name = "NicknameLbl";
            NicknameLbl.Size = new Size(135, 30);
            NicknameLbl.TabIndex = 21;
            NicknameLbl.Text = "Nickname:";
            // 
            // NicknameLabel
            // 
            NicknameLabel.AutoSize = true;
            NicknameLabel.Font = new Font("Microsoft Sans Serif", 13F);
            NicknameLabel.Location = new Point(496, 348);
            NicknameLabel.Margin = new Padding(4, 0, 4, 0);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(128, 30);
            NicknameLabel.TabIndex = 22;
            NicknameLabel.Text = "Nickname";
            // 
            // EditUpdateBtn
            // 
            EditUpdateBtn.Location = new Point(411, 435);
            EditUpdateBtn.Margin = new Padding(4, 5, 4, 5);
            EditUpdateBtn.Name = "EditUpdateBtn";
            EditUpdateBtn.Size = new Size(176, 50);
            EditUpdateBtn.TabIndex = 23;
            EditUpdateBtn.Text = "Edit/Update";
            EditUpdateBtn.UseVisualStyleBackColor = true;
            EditUpdateBtn.Click += EditUpdateBtn_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 685);
            Controls.Add(EditUpdateBtn);
            Controls.Add(NicknameLabel);
            Controls.Add(NicknameLbl);
            Controls.Add(HobbiesLabel);
            Controls.Add(HobbiesLbl);
            Controls.Add(ParentContactLabel);
            Controls.Add(ParentContactLbl);
            Controls.Add(ParentNameLabel);
            Controls.Add(ParentNameLbl);
            Controls.Add(StudentCourseYearLabel);
            Controls.Add(CourseYearLabel);
            Controls.Add(StudentEmailLabel);
            Controls.Add(EmailLabel);
            Controls.Add(StudentContactLabel);
            Controls.Add(ContactLabel);
            Controls.Add(StudentAddressLabel);
            Controls.Add(AddressLabel);
            Controls.Add(StudentAgeLabel);
            Controls.Add(AgeLabel);
            Controls.Add(NameLabel);
            Controls.Add(StudentNameLabel);
            Controls.Add(ChangeImageBtn);
            Controls.Add(AddImageBtn);
            Controls.Add(StudentPictureBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "StudentForm";
            Text = "Student Page";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)StudentPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void UpdateStudentInfo(UserProfile userProfile)
        {
            StudentNameLabel.Text = userProfile.Name;
            StudentAgeLabel.Text = userProfile.Age.ToString();
            StudentAddressLabel.Text = userProfile.Address;
            StudentContactLabel.Text = userProfile.ContactNumber;
            StudentEmailLabel.Text = userProfile.Email;
            StudentCourseYearLabel.Text = $"{userProfile.Course} {userProfile.Year}";
            ParentNameLabel.Text = userProfile.ParentName;
            ParentContactLabel.Text = userProfile.ParentContact;
            HobbiesLabel.Text = userProfile.Hobbies;
            NicknameLabel.Text = userProfile.Nickname;
        }


        #endregion

        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.Button AddImageBtn;
        private System.Windows.Forms.Button ChangeImageBtn;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label StudentAgeLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label StudentAddressLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label StudentContactLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label StudentEmailLabel;
        private System.Windows.Forms.Label CourseYearLabel;
        private System.Windows.Forms.Label StudentCourseYearLabel;
        private System.Windows.Forms.Label ParentNameLbl;
        private System.Windows.Forms.Label ParentNameLabel;
        private System.Windows.Forms.Label ParentContactLbl;
        private System.Windows.Forms.Label ParentContactLabel;
        private System.Windows.Forms.Label HobbiesLbl;
        private System.Windows.Forms.Label HobbiesLabel;
        private System.Windows.Forms.Label NicknameLbl;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Button EditUpdateBtn;
    }
}