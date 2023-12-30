namespace FinalAssignmentWorkTasks.Forms
{
    partial class TaskDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDashboard));
            btnMenu = new Button();
            dataGridViewTasks = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblUserDepartment = new Label();
            lblUserLastname = new Label();
            lblUserFirstname = new Label();
            lblUserEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlText;
            btnMenu.Location = new Point(12, 502);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(111, 47);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.AllowUserToDeleteRows = false;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(12, 12);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.Size = new Size(727, 484);
            dataGridViewTasks.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(745, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 318);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblUserDepartment);
            groupBox2.Controls.Add(lblUserLastname);
            groupBox2.Controls.Add(lblUserFirstname);
            groupBox2.Controls.Add(lblUserEmail);
            groupBox2.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(745, 336);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 160);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "User info";
            // 
            // lblUserDepartment
            // 
            lblUserDepartment.AutoSize = true;
            lblUserDepartment.Location = new Point(6, 120);
            lblUserDepartment.Name = "lblUserDepartment";
            lblUserDepartment.Size = new Size(69, 18);
            lblUserDepartment.TabIndex = 3;
            lblUserDepartment.Text = "Department:";
            // 
            // lblUserLastname
            // 
            lblUserLastname.AutoSize = true;
            lblUserLastname.Location = new Point(6, 89);
            lblUserLastname.Name = "lblUserLastname";
            lblUserLastname.Size = new Size(62, 18);
            lblUserLastname.TabIndex = 2;
            lblUserLastname.Text = "Last name:";
            // 
            // lblUserFirstname
            // 
            lblUserFirstname.AutoSize = true;
            lblUserFirstname.Location = new Point(6, 56);
            lblUserFirstname.Name = "lblUserFirstname";
            lblUserFirstname.Size = new Size(64, 18);
            lblUserFirstname.TabIndex = 1;
            lblUserFirstname.Text = "First name:";
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Location = new Point(6, 26);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(38, 18);
            lblUserEmail.TabIndex = 0;
            lblUserEmail.Text = "Email:";
            // 
            // TaskDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(984, 561);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewTasks);
            Controls.Add(btnMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TaskDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskDashboard";
            FormClosed += TaskDashboard_FormClosed;
            Load += TaskDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private DataGridView dataGridViewTasks;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblUserDepartment;
        private Label lblUserLastname;
        private Label lblUserFirstname;
        private Label lblUserEmail;
    }
}