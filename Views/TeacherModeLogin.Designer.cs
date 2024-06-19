namespace BBB.Views
{
    partial class TeacherModeLogin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            usernameLabel = new Label();
            passwordLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            CancelLoginButton = new Button();
            LoginButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.Controls.Add(usernameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(passwordLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(CancelLoginButton, 0, 4);
            tableLayoutPanel1.Controls.Add(LoginButton, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(531, 290);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(51, 56);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(121, 32);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(61, 104);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(111, 32);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(178, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(178, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 39);
            textBox2.TabIndex = 3;
            // 
            // CancelLoginButton
            // 
            CancelLoginButton.Anchor = AnchorStyles.None;
            CancelLoginButton.Location = new Point(12, 195);
            CancelLoginButton.Name = "CancelLoginButton";
            CancelLoginButton.Size = new Size(150, 42);
            CancelLoginButton.TabIndex = 4;
            CancelLoginButton.Text = "Cancel";
            CancelLoginButton.UseVisualStyleBackColor = true;
            CancelLoginButton.Click += CancelButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.Location = new Point(278, 195);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 42);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // TeacherModeLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 290);
            Controls.Add(tableLayoutPanel1);
            Name = "TeacherModeLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TeacherModeLogin";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button CancelLoginButton;
        private Button LoginButton;
    }
}