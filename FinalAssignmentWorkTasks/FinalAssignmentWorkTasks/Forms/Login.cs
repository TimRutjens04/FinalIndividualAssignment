using FinalAssignmentWorkTasks.Forms;

namespace FinalAssignmentWorkTasks
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ///
            /// Add login logic later
            ///
            this.Hide();
            var temp = new Menu();
            temp.Show();
        }
    }
}