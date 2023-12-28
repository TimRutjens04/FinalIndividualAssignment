namespace FinalAssignmentWorkTasks.Forms
{
    partial class Menu
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
            label1 = new Label();
            btnLogOut = new Button();
            btnDashboard = new Button();
            btnNewTask = new Button();
            btnSettings = new Button();
            gbxLoggedInUser = new GroupBox();
            lblUserFirstname = new Label();
            lblUserDepartment = new Label();
            lblUserLastname = new Label();
            lblUserEmail = new Label();
            gbxLoggedInUser.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 58);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = SystemColors.ControlText;
            btnLogOut.Location = new Point(417, 334);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(111, 47);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = SystemColors.ControlText;
            btnDashboard.Location = new Point(417, 119);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(111, 47);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnNewTask
            // 
            btnNewTask.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewTask.ForeColor = SystemColors.ControlText;
            btnNewTask.Location = new Point(417, 190);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(111, 47);
            btnNewTask.TabIndex = 3;
            btnNewTask.Text = "New task";
            btnNewTask.UseVisualStyleBackColor = true;
            btnNewTask.Click += btnNewTask_Click;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = SystemColors.ControlText;
            btnSettings.Location = new Point(417, 262);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(111, 47);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // gbxLoggedInUser
            // 
            gbxLoggedInUser.BackColor = Color.White;
            gbxLoggedInUser.Controls.Add(lblUserFirstname);
            gbxLoggedInUser.Controls.Add(lblUserDepartment);
            gbxLoggedInUser.Controls.Add(lblUserLastname);
            gbxLoggedInUser.Controls.Add(lblUserEmail);
            gbxLoggedInUser.Location = new Point(695, 12);
            gbxLoggedInUser.Name = "gbxLoggedInUser";
            gbxLoggedInUser.Size = new Size(277, 165);
            gbxLoggedInUser.TabIndex = 6;
            gbxLoggedInUser.TabStop = false;
            gbxLoggedInUser.Text = "Logged in user details:";
            // 
            // lblUserFirstname
            // 
            lblUserFirstname.AutoSize = true;
            lblUserFirstname.Location = new Point(6, 65);
            lblUserFirstname.Name = "lblUserFirstname";
            lblUserFirstname.Size = new Size(65, 15);
            lblUserFirstname.TabIndex = 3;
            lblUserFirstname.Text = "First name:";
            // 
            // lblUserDepartment
            // 
            lblUserDepartment.AutoSize = true;
            lblUserDepartment.Location = new Point(6, 128);
            lblUserDepartment.Name = "lblUserDepartment";
            lblUserDepartment.Size = new Size(73, 15);
            lblUserDepartment.TabIndex = 2;
            lblUserDepartment.Text = "Department:";
            // 
            // lblUserLastname
            // 
            lblUserLastname.AutoSize = true;
            lblUserLastname.Location = new Point(6, 96);
            lblUserLastname.Name = "lblUserLastname";
            lblUserLastname.Size = new Size(64, 15);
            lblUserLastname.TabIndex = 1;
            lblUserLastname.Text = "Last name:";
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Location = new Point(6, 33);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(39, 15);
            lblUserEmail.TabIndex = 0;
            lblUserEmail.Text = "Email:";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(984, 561);
            Controls.Add(gbxLoggedInUser);
            Controls.Add(btnSettings);
            Controls.Add(btnNewTask);
            Controls.Add(btnDashboard);
            Controls.Add(btnLogOut);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosed += Menu_FormClosed;
            gbxLoggedInUser.ResumeLayout(false);
            gbxLoggedInUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogOut;
        private Button btnDashboard;
        private Button btnNewTask;
        private Button btnSettings;
        private GroupBox gbxLoggedInUser;
        private Label lblUserFirstname;
        private Label lblUserDepartment;
        private Label lblUserLastname;
        private Label lblUserEmail;
    }
}