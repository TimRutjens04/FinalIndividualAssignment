namespace FinalAssignmentWorkTasks.Forms
{
    partial class ChangeTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeTask));
            btnMenu = new Button();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlText;
            btnMenu.Location = new Point(12, 502);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(111, 47);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // ChangeTask
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(984, 561);
            Controls.Add(btnMenu);
            Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "ChangeTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeTask";
            FormClosed += ChangeTask_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
    }
}