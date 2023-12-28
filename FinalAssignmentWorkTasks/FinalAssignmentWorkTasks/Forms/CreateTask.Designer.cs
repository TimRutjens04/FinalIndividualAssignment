namespace FinalAssignmentWorkTasks.Forms
{
    partial class CreateTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTask));
            btnMenu = new Button();
            btnCreateTask = new Button();
            tbxTaskName = new TextBox();
            tbxTaskDescription = new TextBox();
            gbxTaskInfo = new GroupBox();
            clbxAssignedEmployees = new CheckedListBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            lblDepartment = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            monthCalendarDueTime = new MonthCalendar();
            gbxTaskInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlText;
            btnMenu.Location = new Point(12, 502);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(111, 47);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnCreateTask
            // 
            btnCreateTask.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateTask.ForeColor = SystemColors.ControlText;
            btnCreateTask.Location = new Point(21, 468);
            btnCreateTask.Name = "btnCreateTask";
            btnCreateTask.Size = new Size(772, 54);
            btnCreateTask.TabIndex = 4;
            btnCreateTask.Text = "Create task";
            btnCreateTask.UseVisualStyleBackColor = true;
            btnCreateTask.Click += btnCreateTask_Click;
            // 
            // tbxTaskName
            // 
            tbxTaskName.Location = new Point(151, 76);
            tbxTaskName.Name = "tbxTaskName";
            tbxTaskName.Size = new Size(249, 27);
            tbxTaskName.TabIndex = 5;
            // 
            // tbxTaskDescription
            // 
            tbxTaskDescription.Location = new Point(151, 110);
            tbxTaskDescription.Multiline = true;
            tbxTaskDescription.Name = "tbxTaskDescription";
            tbxTaskDescription.ScrollBars = ScrollBars.Vertical;
            tbxTaskDescription.Size = new Size(249, 146);
            tbxTaskDescription.TabIndex = 6;
            // 
            // gbxTaskInfo
            // 
            gbxTaskInfo.Controls.Add(clbxAssignedEmployees);
            gbxTaskInfo.Controls.Add(checkBox5);
            gbxTaskInfo.Controls.Add(checkBox4);
            gbxTaskInfo.Controls.Add(checkBox3);
            gbxTaskInfo.Controls.Add(checkBox2);
            gbxTaskInfo.Controls.Add(checkBox1);
            gbxTaskInfo.Controls.Add(lblDepartment);
            gbxTaskInfo.Controls.Add(label4);
            gbxTaskInfo.Controls.Add(label3);
            gbxTaskInfo.Controls.Add(label2);
            gbxTaskInfo.Controls.Add(label1);
            gbxTaskInfo.Controls.Add(monthCalendarDueTime);
            gbxTaskInfo.Controls.Add(btnCreateTask);
            gbxTaskInfo.Controls.Add(tbxTaskName);
            gbxTaskInfo.Controls.Add(tbxTaskDescription);
            gbxTaskInfo.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbxTaskInfo.Location = new Point(159, 12);
            gbxTaskInfo.Name = "gbxTaskInfo";
            gbxTaskInfo.Size = new Size(813, 537);
            gbxTaskInfo.TabIndex = 8;
            gbxTaskInfo.TabStop = false;
            gbxTaskInfo.Text = "Task info";
            // 
            // clbxAssignedEmployees
            // 
            clbxAssignedEmployees.CheckOnClick = true;
            clbxAssignedEmployees.FormattingEnabled = true;
            clbxAssignedEmployees.HorizontalScrollbar = true;
            clbxAssignedEmployees.Location = new Point(544, 171);
            clbxAssignedEmployees.Name = "clbxAssignedEmployees";
            clbxAssignedEmployees.ScrollAlwaysVisible = true;
            clbxAssignedEmployees.Size = new Size(245, 268);
            clbxAssignedEmployees.TabIndex = 20;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(496, 136);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(172, 23);
            checkBox5.TabIndex = 19;
            checkBox5.Text = "Research and Development";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(639, 109);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(69, 23);
            checkBox4.TabIndex = 18;
            checkBox4.Text = "Support";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(496, 107);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(58, 23);
            checkBox3.TabIndex = 17;
            checkBox3.Text = "Sales";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(640, 80);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(81, 23);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Marketing";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(496, 78);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(42, 23);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "HR";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(576, 42);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(74, 19);
            lblDepartment.TabIndex = 14;
            lblDepartment.Text = "Department:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 332);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 13;
            label4.Text = "Due date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 171);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 12;
            label3.Text = "Assigned employees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 171);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 11;
            label2.Text = "Task description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 79);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 10;
            label1.Text = "Task name:";
            // 
            // monthCalendarDueTime
            // 
            monthCalendarDueTime.Location = new Point(151, 268);
            monthCalendarDueTime.Name = "monthCalendarDueTime";
            monthCalendarDueTime.ShowToday = false;
            monthCalendarDueTime.ShowWeekNumbers = true;
            monthCalendarDueTime.TabIndex = 9;
            // 
            // CreateTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(984, 561);
            Controls.Add(gbxTaskInfo);
            Controls.Add(btnMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateTask";
            FormClosed += CreateTask_FormClosed;
            gbxTaskInfo.ResumeLayout(false);
            gbxTaskInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Button btnCreateTask;
        private TextBox tbxTaskName;
        private TextBox tbxTaskDescription;
        private GroupBox gbxTaskInfo;
        private Label label1;
        private MonthCalendar monthCalendarDueTime;
        private Label lblDepartment;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckedListBox clbxAssignedEmployees;
    }
}