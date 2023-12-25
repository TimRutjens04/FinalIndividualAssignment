namespace FinalAssignmentWorkTasks
{
    partial class EntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            label1 = new Label();
            tbxUsername = new TextBox();
            btnLogin = new Button();
            cbxRememberMe = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            tbxPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(429, 41);
            label1.Name = "label1";
            label1.Size = new Size(114, 58);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = SystemColors.Info;
            tbxUsername.Cursor = Cursors.IBeam;
            tbxUsername.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxUsername.Location = new Point(418, 166);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(200, 22);
            tbxUsername.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(428, 343);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // cbxRememberMe
            // 
            cbxRememberMe.AutoSize = true;
            cbxRememberMe.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxRememberMe.Location = new Point(429, 295);
            cbxRememberMe.Name = "cbxRememberMe";
            cbxRememberMe.Size = new Size(130, 29);
            cbxRememberMe.TabIndex = 4;
            cbxRememberMe.Text = "Remember me";
            cbxRememberMe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(304, 156);
            label3.Name = "label3";
            label3.Size = new Size(109, 33);
            label3.TabIndex = 6;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 219);
            label2.Name = "label2";
            label2.Size = new Size(106, 33);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = SystemColors.Info;
            tbxPassword.Cursor = Cursors.IBeam;
            tbxPassword.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.Location = new Point(418, 229);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(200, 22);
            tbxPassword.TabIndex = 8;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(984, 561);
            Controls.Add(tbxPassword);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cbxRememberMe);
            Controls.Add(btnLogin);
            Controls.Add(tbxUsername);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EntryForm";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox tbxUsername;
        private Button btnLogin;
        private CheckBox cbxRememberMe;
        private Label label3;
        private Label label2;
        private TextBox tbxPassword;
    }
}