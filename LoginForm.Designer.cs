namespace Velasco_Arjay_Act_GUI
{
    partial class LoginForm
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
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 13F);
            UsernameLabel.Location = new Point(39, 105);
            UsernameLabel.Margin = new Padding(6, 0, 6, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(137, 36);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 13F);
            PasswordLabel.Location = new Point(39, 205);
            PasswordLabel.Margin = new Padding(6, 0, 6, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(128, 36);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Segoe UI", 8.25F);
            UsernameTextBox.Location = new Point(200, 113);
            UsernameTextBox.Margin = new Padding(6, 5, 6, 5);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(331, 29);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 8.25F);
            PasswordTextBox.Location = new Point(200, 213);
            PasswordTextBox.Margin = new Padding(6, 5, 6, 5);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(331, 29);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(307, 293);
            LoginBtn.Margin = new Padding(6, 5, 6, 5);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(126, 45);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 405);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Margin = new Padding(6, 5, 6, 5);
            Name = "LoginForm";
            Text = "Login Page";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginBtn;
    }
}