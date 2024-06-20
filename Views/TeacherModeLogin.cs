using BBB.Controllers;
using System.Diagnostics;

namespace BBB.Views
{
    public partial class TeacherModeLogin : Form
    {
        AuthController authController;
        public TeacherModeLogin()
        {
            InitializeComponent();
            authController = new AuthController();
            ErrorLabel.Visible = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Boolean auth = authController.ValidateUser(UsernameTextBox.Text, PasswordTextBox.Text);
            Debug.WriteLine($"auth = {auth}");
            ErrorLabel.Visible = !auth;
            if (auth)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
