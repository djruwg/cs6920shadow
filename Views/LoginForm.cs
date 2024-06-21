using BBB.Controllers;

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
        }

        /// <summary>
        /// Performs an authentication when clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The event</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean authenticated = _authController.ValidateUser(UsernameTextBox.Text, PasswordTextBox.Text);

                ErrorMessageLabel.Visible = !authenticated;

                if (authenticated)
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

        /// <summary>
        /// Cancels authentication when clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The event</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Clears the message label when the username field is typed in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ErrorMessageLabel.Text.Equals(""))
            {
                ErrorMessageLabel.Text = "";
            }
        }

        /// <summary>
        /// Clears the message label when the password field is typed in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ErrorMessageLabel.Text.Equals(""))
            {
                ErrorMessageLabel.Text = "";
            }
        }
    }
}
