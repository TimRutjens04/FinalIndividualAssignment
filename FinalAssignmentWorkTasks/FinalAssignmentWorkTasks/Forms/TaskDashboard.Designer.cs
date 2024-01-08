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
            tbxId = new TextBox();
            tbxTitle = new TextBox();
            cbxStatusInProgress = new CheckBox();
            cbxStatusCompleted = new CheckBox();
            cbxStatusBlocked = new CheckBox();
            cbxStatusCancelled = new CheckBox();
            cbxStatusOpen = new CheckBox();
            cbxDepartmentMarketing = new CheckBox();
            cbxDepartmentSales = new CheckBox();
            cbxDepartmentRd = new CheckBox();
            cbxDepartmentSupport = new CheckBox();
            cbxDepartmentHr = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblUserDepartment = new Label();
            lblUserLastname = new Label();
            lblUserFirstname = new Label();
            lblUserEmail = new Label();
            btnChangeSelectedTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            groupBox1.SuspendLayout();
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
            dataGridViewTasks.RowHeadersWidth = 62;
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.Size = new Size(727, 484);
            dataGridViewTasks.TabIndex = 3;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tbxId);
            groupBox1.Controls.Add(tbxTitle);
            groupBox1.Controls.Add(cbxStatusInProgress);
            groupBox1.Controls.Add(cbxStatusCompleted);
            groupBox1.Controls.Add(cbxStatusBlocked);
            groupBox1.Controls.Add(cbxStatusCancelled);
            groupBox1.Controls.Add(cbxStatusOpen);
            groupBox1.Controls.Add(cbxDepartmentMarketing);
            groupBox1.Controls.Add(cbxDepartmentSales);
            groupBox1.Controls.Add(cbxDepartmentRd);
            groupBox1.Controls.Add(cbxDepartmentSupport);
            groupBox1.Controls.Add(cbxDepartmentHr);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(745, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 318);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls";
            // 
            // tbxId
            // 
            tbxId.BackColor = SystemColors.Info;
            tbxId.Location = new Point(43, 81);
            tbxId.Margin = new Padding(2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(168, 25);
            tbxId.TabIndex = 17;
            // 
            // tbxTitle
            // 
            tbxTitle.BackColor = SystemColors.Info;
            tbxTitle.Location = new Point(43, 43);
            tbxTitle.Margin = new Padding(2);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(168, 25);
            tbxTitle.TabIndex = 16;
            // 
            // cbxStatusInProgress
            // 
            cbxStatusInProgress.AutoSize = true;
            cbxStatusInProgress.Location = new Point(58, 213);
            cbxStatusInProgress.Margin = new Padding(2);
            cbxStatusInProgress.Name = "cbxStatusInProgress";
            cbxStatusInProgress.Size = new Size(83, 22);
            cbxStatusInProgress.TabIndex = 14;
            cbxStatusInProgress.Text = "In progress";
            cbxStatusInProgress.UseVisualStyleBackColor = true;
            // 
            // cbxStatusCompleted
            // 
            cbxStatusCompleted.AutoSize = true;
            cbxStatusCompleted.Location = new Point(146, 213);
            cbxStatusCompleted.Margin = new Padding(2);
            cbxStatusCompleted.Name = "cbxStatusCompleted";
            cbxStatusCompleted.Size = new Size(79, 22);
            cbxStatusCompleted.TabIndex = 13;
            cbxStatusCompleted.Text = "Completed";
            cbxStatusCompleted.UseVisualStyleBackColor = true;
            // 
            // cbxStatusBlocked
            // 
            cbxStatusBlocked.AutoSize = true;
            cbxStatusBlocked.Location = new Point(34, 236);
            cbxStatusBlocked.Margin = new Padding(2);
            cbxStatusBlocked.Name = "cbxStatusBlocked";
            cbxStatusBlocked.Size = new Size(66, 22);
            cbxStatusBlocked.TabIndex = 12;
            cbxStatusBlocked.Text = "Blocked";
            cbxStatusBlocked.UseVisualStyleBackColor = true;
            // 
            // cbxStatusCancelled
            // 
            cbxStatusCancelled.AutoSize = true;
            cbxStatusCancelled.Location = new Point(112, 236);
            cbxStatusCancelled.Margin = new Padding(2);
            cbxStatusCancelled.Name = "cbxStatusCancelled";
            cbxStatusCancelled.Size = new Size(75, 22);
            cbxStatusCancelled.TabIndex = 11;
            cbxStatusCancelled.Text = "Cancelled";
            cbxStatusCancelled.UseVisualStyleBackColor = true;
            // 
            // cbxStatusOpen
            // 
            cbxStatusOpen.AutoSize = true;
            cbxStatusOpen.Location = new Point(6, 213);
            cbxStatusOpen.Margin = new Padding(2);
            cbxStatusOpen.Name = "cbxStatusOpen";
            cbxStatusOpen.Size = new Size(52, 22);
            cbxStatusOpen.TabIndex = 10;
            cbxStatusOpen.Text = "Open";
            cbxStatusOpen.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentMarketing
            // 
            cbxDepartmentMarketing.AutoSize = true;
            cbxDepartmentMarketing.Location = new Point(69, 151);
            cbxDepartmentMarketing.Margin = new Padding(2);
            cbxDepartmentMarketing.Name = "cbxDepartmentMarketing";
            cbxDepartmentMarketing.Size = new Size(77, 22);
            cbxDepartmentMarketing.TabIndex = 9;
            cbxDepartmentMarketing.Text = "Marketing";
            cbxDepartmentMarketing.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentSales
            // 
            cbxDepartmentSales.AutoSize = true;
            cbxDepartmentSales.Location = new Point(151, 151);
            cbxDepartmentSales.Margin = new Padding(2);
            cbxDepartmentSales.Name = "cbxDepartmentSales";
            cbxDepartmentSales.Size = new Size(53, 22);
            cbxDepartmentSales.TabIndex = 8;
            cbxDepartmentSales.Text = "Sales";
            cbxDepartmentSales.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentRd
            // 
            cbxDepartmentRd.AutoSize = true;
            cbxDepartmentRd.Location = new Point(34, 173);
            cbxDepartmentRd.Margin = new Padding(2);
            cbxDepartmentRd.Name = "cbxDepartmentRd";
            cbxDepartmentRd.Size = new Size(64, 22);
            cbxDepartmentRd.TabIndex = 7;
            cbxDepartmentRd.Text = "R and D";
            cbxDepartmentRd.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentSupport
            // 
            cbxDepartmentSupport.AutoSize = true;
            cbxDepartmentSupport.Location = new Point(112, 173);
            cbxDepartmentSupport.Margin = new Padding(2);
            cbxDepartmentSupport.Name = "cbxDepartmentSupport";
            cbxDepartmentSupport.Size = new Size(66, 22);
            cbxDepartmentSupport.TabIndex = 6;
            cbxDepartmentSupport.Text = "Support";
            cbxDepartmentSupport.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentHr
            // 
            cbxDepartmentHr.AutoSize = true;
            cbxDepartmentHr.Location = new Point(25, 151);
            cbxDepartmentHr.Margin = new Padding(2);
            cbxDepartmentHr.Name = "cbxDepartmentHr";
            cbxDepartmentHr.Size = new Size(40, 22);
            cbxDepartmentHr.TabIndex = 2;
            cbxDepartmentHr.Text = "HR";
            cbxDepartmentHr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 18);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 18);
            label1.TabIndex = 0;
            label1.Text = "Title:";
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
            // btnChangeSelectedTask
            // 
            btnChangeSelectedTask.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeSelectedTask.ForeColor = SystemColors.ControlText;
            btnChangeSelectedTask.Location = new Point(129, 502);
            btnChangeSelectedTask.Name = "btnChangeSelectedTask";
            btnChangeSelectedTask.Size = new Size(167, 47);
            btnChangeSelectedTask.TabIndex = 6;
            btnChangeSelectedTask.Text = "Edit selected task";
            btnChangeSelectedTask.UseVisualStyleBackColor = true;
            // 
            // TaskDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(984, 561);
            Controls.Add(btnChangeSelectedTask);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private CheckBox cbxDepartmentMarketing;
        private CheckBox cbxDepartmentSales;
        private CheckBox cbxDepartmentRd;
        private CheckBox cbxDepartmentSupport;
        private CheckBox cbxDepartmentHr;
        private Label label2;
        private Label label1;
        private CheckBox cbxStatusInProgress;
        private CheckBox cbxStatusCompleted;
        private CheckBox cbxStatusBlocked;
        private CheckBox cbxStatusCancelled;
        private CheckBox cbxStatusOpen;
        private TextBox tbxId;
        private TextBox tbxTitle;
        private Button btnChangeSelectedTask;
    }
}