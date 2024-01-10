namespace FinalAssignmentWorkTasks.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            btnMenu = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlText;
            btnMenu.Location = new Point(12, 843);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(159, 78);
            btnMenu.TabIndex = 8;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnSettings_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(119, 34);
            label1.TabIndex = 4;
            label1.Text = "First name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 475);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Current employee information";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(719, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(675, 475);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Changes ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 98);
            label2.Name = "label2";
            label2.Size = new Size(115, 34);
            label2.TabIndex = 5;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 149);
            label3.Name = "label3";
            label3.Size = new Size(72, 34);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 200);
            label4.Name = "label4";
            label4.Size = new Size(84, 34);
            label4.TabIndex = 7;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 248);
            label5.Name = "label5";
            label5.Size = new Size(134, 34);
            label5.TabIndex = 8;
            label5.Text = "Street name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 382);
            label6.Name = "label6";
            label6.Size = new Size(54, 34);
            label6.TabIndex = 9;
            label6.Text = "City:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 337);
            label7.Name = "label7";
            label7.Size = new Size(96, 34);
            label7.TabIndex = 10;
            label7.Text = "Zip code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 294);
            label8.Name = "label8";
            label8.Size = new Size(153, 34);
            label8.TabIndex = 11;
            label8.Text = "Street number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 426);
            label10.Name = "label10";
            label10.Size = new Size(109, 34);
            label10.TabIndex = 13;
            label10.Text = "Password:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(11F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1406, 935);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnMenu);
            Font = new Font("Bahnschrift Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 7, 4, 7);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosed += Settings_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
    }
}