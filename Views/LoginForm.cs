using BBB.Controllers;
using System.Diagnostics;

namespace BBB.Views
{
    /// <summary>
    /// Presents a login modal form
    /// </summary>
    public partial class LoginForm : Form
    {
        private AuthController _authController;

        /// <summary>
        /// Constructor for the login form
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            _authController = new AuthController();
            // ErrorMessageLabel.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean auth = _authController.ValidateUser(UsernameTextBox.Text, PasswordTextBox.Text);
                Debug.WriteLine($"auth = {auth}");
                ErrorMessageLabel.Visible = !auth;

                if (auth)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    ErrorMessageLabel.Text = "Invalid username/password.";
                }
            }
            catch
            {
                ErrorMessageLabel.Text = "Authentication unavailable.";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ErrorMessageLabel.Text.Equals(""))
            {
                ErrorMessageLabel.Text = "";
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ErrorMessageLabel.Text.Equals(""))
            {
                ErrorMessageLabel.Text = "";
            }
        }
    }
}
