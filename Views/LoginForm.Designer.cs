namespace BBB.Views
{
    partial class LoginForm
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
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ErrorMessageLabel = new Label();
            LoginTableLayoutPanel = new TableLayoutPanel();
            LoginButton = new Button();
            CancelButton = new Button();
            LoginTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(24, 20);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(121, 32);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(24, 63);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(111, 32);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            LoginTableLayoutPanel.SetColumnSpan(UsernameTextBox, 2);
            UsernameTextBox.Location = new Point(164, 22);
            UsernameTextBox.Margin = new Padding(4, 2, 4, 2);
            UsernameTextBox.MaxLength = 16;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(414, 39);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginTableLayoutPanel.SetColumnSpan(PasswordTextBox, 2);
            PasswordTextBox.Location = new Point(164, 65);
            PasswordTextBox.Margin = new Padding(4, 2, 4, 2);
            PasswordTextBox.MaxLength = 32;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(414, 39);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.AutoSize = true;
            LoginTableLayoutPanel.SetColumnSpan(ErrorMessageLabel, 3);
            ErrorMessageLabel.ForeColor = Color.Red;
            ErrorMessageLabel.Location = new Point(24, 106);
            ErrorMessageLabel.Margin = new Padding(4, 0, 4, 0);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(0, 32);
            ErrorMessageLabel.TabIndex = 5;
            // 
            // LoginTableLayoutPanel
            // 
            LoginTableLayoutPanel.ColumnCount = 3;
            LoginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LoginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            LoginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            LoginTableLayoutPanel.Controls.Add(UsernameLabel, 0, 0);
            LoginTableLayoutPanel.Controls.Add(PasswordTextBox, 1, 1);
            LoginTableLayoutPanel.Controls.Add(ErrorMessageLabel, 0, 2);
            LoginTableLayoutPanel.Controls.Add(PasswordLabel, 0, 1);
            LoginTableLayoutPanel.Controls.Add(UsernameTextBox, 1, 0);
            LoginTableLayoutPanel.Controls.Add(LoginButton, 2, 3);
            LoginTableLayoutPanel.Controls.Add(CancelButton, 1, 3);
            LoginTableLayoutPanel.Dock = DockStyle.Fill;
            LoginTableLayoutPanel.Location = new Point(0, 0);
            LoginTableLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            LoginTableLayoutPanel.Name = "LoginTableLayoutPanel";
            LoginTableLayoutPanel.Padding = new Padding(20);
            LoginTableLayoutPanel.RowCount = 4;
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle());
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle());
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle());
            LoginTableLayoutPanel.RowStyles.Add(new RowStyle());
            LoginTableLayoutPanel.Size = new Size(602, 218);
            LoginTableLayoutPanel.TabIndex = 6;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginButton.Location = new Point(428, 149);
            LoginButton.Margin = new Padding(4, 2, 4, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 47);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.Location = new Point(164, 149);
            CancelButton.Margin = new Padding(4, 2, 4, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(150, 47);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 218);
            Controls.Add(LoginTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher Login";
            LoginTableLayoutPanel.ResumeLayout(false);
            LoginTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label ErrorMessageLabel;
        private TableLayoutPanel LoginTableLayoutPanel;
        private Button LoginButton;
        private Button CancelButton;
    }
}
