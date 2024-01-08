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
            label1 = new Label();
            label2 = new Label();
            cbxDepartmentHr = new CheckBox();
            cbxDepartmentSupport = new CheckBox();
            cbxDepartmentRd = new CheckBox();
            cbxDepartmentSales = new CheckBox();
            cbxDepartmentMarketing = new CheckBox();
            cbxStatusInProgress = new CheckBox();
            cbxStatusCompleted = new CheckBox();
            cbxStatusBlocked = new CheckBox();
            cbxStatusCancelled = new CheckBox();
            cbxStatusOpen = new CheckBox();
            btnFilter = new Button();
            tbxTitle = new TextBox();
            tbxId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlText;
            btnMenu.Location = new Point(17, 837);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(159, 78);
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
            dataGridViewTasks.Location = new Point(17, 20);
            dataGridViewTasks.Margin = new Padding(4, 5, 4, 5);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowHeadersWidth = 62;
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.Size = new Size(1039, 807);
            dataGridViewTasks.TabIndex = 3;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tbxId);
            groupBox1.Controls.Add(tbxTitle);
            groupBox1.Controls.Add(btnFilter);
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
            groupBox1.Location = new Point(1064, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(324, 530);
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
            groupBox2.Location = new Point(1064, 560);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(324, 267);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "User info";
            // 
            // lblUserDepartment
            // 
            lblUserDepartment.AutoSize = true;
            lblUserDepartment.Location = new Point(9, 200);
            lblUserDepartment.Margin = new Padding(4, 0, 4, 0);
            lblUserDepartment.Name = "lblUserDepartment";
            lblUserDepartment.Size = new Size(105, 28);
            lblUserDepartment.TabIndex = 3;
            lblUserDepartment.Text = "Department:";
            // 
            // lblUserLastname
            // 
            lblUserLastname.AutoSize = true;
            lblUserLastname.Location = new Point(9, 148);
            lblUserLastname.Margin = new Padding(4, 0, 4, 0);
            lblUserLastname.Name = "lblUserLastname";
            lblUserLastname.Size = new Size(94, 28);
            lblUserLastname.TabIndex = 2;
            lblUserLastname.Text = "Last name:";
            // 
            // lblUserFirstname
            // 
            lblUserFirstname.AutoSize = true;
            lblUserFirstname.Location = new Point(9, 93);
            lblUserFirstname.Margin = new Padding(4, 0, 4, 0);
            lblUserFirstname.Name = "lblUserFirstname";
            lblUserFirstname.Size = new Size(97, 28);
            lblUserFirstname.TabIndex = 1;
            lblUserFirstname.Text = "First name:";
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Location = new Point(9, 43);
            lblUserEmail.Margin = new Padding(4, 0, 4, 0);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(58, 28);
            lblUserEmail.TabIndex = 0;
            lblUserEmail.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 72);
            label1.Name = "label1";
            label1.Size = new Size(48, 27);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 135);
            label2.Name = "label2";
            label2.Size = new Size(33, 27);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // cbxDepartmentHr
            // 
            cbxDepartmentHr.AutoSize = true;
            cbxDepartmentHr.Location = new Point(41, 215);
            cbxDepartmentHr.Name = "cbxDepartmentHr";
            cbxDepartmentHr.Size = new Size(57, 31);
            cbxDepartmentHr.TabIndex = 2;
            cbxDepartmentHr.Text = "HR";
            cbxDepartmentHr.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentSupport
            // 
            cbxDepartmentSupport.AutoSize = true;
            cbxDepartmentSupport.Location = new Point(165, 252);
            cbxDepartmentSupport.Name = "cbxDepartmentSupport";
            cbxDepartmentSupport.Size = new Size(95, 31);
            cbxDepartmentSupport.TabIndex = 6;
            cbxDepartmentSupport.Text = "Support";
            cbxDepartmentSupport.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentRd
            // 
            cbxDepartmentRd.AutoSize = true;
            cbxDepartmentRd.Location = new Point(54, 252);
            cbxDepartmentRd.Name = "cbxDepartmentRd";
            cbxDepartmentRd.Size = new Size(92, 31);
            cbxDepartmentRd.TabIndex = 7;
            cbxDepartmentRd.Text = "R and D";
            cbxDepartmentRd.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentSales
            // 
            cbxDepartmentSales.AutoSize = true;
            cbxDepartmentSales.Location = new Point(222, 215);
            cbxDepartmentSales.Name = "cbxDepartmentSales";
            cbxDepartmentSales.Size = new Size(78, 31);
            cbxDepartmentSales.TabIndex = 8;
            cbxDepartmentSales.Text = "Sales";
            cbxDepartmentSales.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentMarketing
            // 
            cbxDepartmentMarketing.AutoSize = true;
            cbxDepartmentMarketing.Location = new Point(104, 215);
            cbxDepartmentMarketing.Name = "cbxDepartmentMarketing";
            cbxDepartmentMarketing.Size = new Size(112, 31);
            cbxDepartmentMarketing.TabIndex = 9;
            cbxDepartmentMarketing.Text = "Marketing";
            cbxDepartmentMarketing.UseVisualStyleBackColor = true;
            // 
            // cbxStatusInProgress
            // 
            cbxStatusInProgress.AutoSize = true;
            cbxStatusInProgress.Location = new Point(88, 319);
            cbxStatusInProgress.Name = "cbxStatusInProgress";
            cbxStatusInProgress.Size = new Size(120, 31);
            cbxStatusInProgress.TabIndex = 14;
            cbxStatusInProgress.Text = "In progress";
            cbxStatusInProgress.UseVisualStyleBackColor = true;
            // 
            // cbxStatusCompleted
            // 
            cbxStatusCompleted.AutoSize = true;
            cbxStatusCompleted.Location = new Point(214, 319);
            cbxStatusCompleted.Name = "cbxStatusCompleted";
            cbxStatusCompleted.Size = new Size(116, 31);
            cbxStatusCompleted.TabIndex = 13;
            cbxStatusCompleted.Text = "Completed";
            cbxStatusCompleted.UseVisualStyleBackColor = true;
            // 
            // cbxStatusBlocked
            // 
            cbxStatusBlocked.AutoSize = true;
            cbxStatusBlocked.Location = new Point(54, 356);
            cbxStatusBlocked.Name = "cbxStatusBlocked";
            cbxStatusBlocked.Size = new Size(95, 31);
            cbxStatusBlocked.TabIndex = 12;
            cbxStatusBlocked.Text = "Blocked";
            cbxStatusBlocked.UseVisualStyleBackColor = true;
            // 
            // cbxStatusCancelled
            // 
            cbxStatusCancelled.AutoSize = true;
            cbxStatusCancelled.Location = new Point(165, 356);
            cbxStatusCancelled.Name = "cbxStatusCancelled";
            cbxStatusCancelled.Size = new Size(110, 31);
            cbxStatusCancelled.TabIndex = 11;
            cbxStatusCancelled.Text = "Cancelled";
            cbxStatusCancelled.UseVisualStyleBackColor = true;
            // 
            // cbxStatusOpen
            // 
            cbxStatusOpen.AutoSize = true;
            cbxStatusOpen.Location = new Point(15, 319);
            cbxStatusOpen.Name = "cbxStatusOpen";
            cbxStatusOpen.Size = new Size(75, 31);
            cbxStatusOpen.TabIndex = 10;
            cbxStatusOpen.Text = "Open";
            cbxStatusOpen.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(41, 449);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(259, 44);
            btnFilter.TabIndex = 15;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // tbxTitle
            // 
            tbxTitle.BackColor = SystemColors.Info;
            tbxTitle.Location = new Point(61, 72);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(239, 34);
            tbxTitle.TabIndex = 16;
            // 
            // tbxId
            // 
            tbxId.BackColor = SystemColors.Info;
            tbxId.Location = new Point(61, 135);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(239, 34);
            tbxId.TabIndex = 17;
            // 
            // TaskDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1406, 935);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewTasks);
            Controls.Add(btnMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnFilter;
        private TextBox tbxId;
        private TextBox tbxTitle;
    }
}