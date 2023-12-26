using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FinalAssignmentWorkTasks.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(Employee employee)
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new TaskDashboard();
            temp.Show();
        }
        private void btnNewTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new CreateTask();
            temp.Show();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Settings();
            temp.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }

        
    }
}
