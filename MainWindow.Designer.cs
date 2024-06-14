namespace BBB
{
    partial class MainWindow
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
            this.MainWindowTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindowMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindowTabControl = new System.Windows.Forms.TabControl();
            this.MainWindowTableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindowFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainWindowBackButton = new System.Windows.Forms.Button();
            this.MainWindowForwardButton = new System.Windows.Forms.Button();
            this.MainWindowReloadButton = new System.Windows.Forms.Button();
            this.MainWindowURLBar = new System.Windows.Forms.TextBox();
            this.MainWindowFlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainWindowNewTabButton = new System.Windows.Forms.Button();
            this.MainWindowTableLayoutPanel1.SuspendLayout();
            this.MainWindowMenuStrip.SuspendLayout();
            this.MainWindowTableLayoutPanel2.SuspendLayout();
            this.MainWindowTableLayoutPanel3.SuspendLayout();
            this.MainWindowFlowLayoutPanel1.SuspendLayout();
            this.MainWindowFlowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowTableLayoutPanel1
            // 
            this.MainWindowTableLayoutPanel1.AutoSize = true;
            this.MainWindowTableLayoutPanel1.ColumnCount = 1;
            this.MainWindowTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowTableLayoutPanel1.Controls.Add(this.MainWindowMenuStrip, 0, 0);
            this.MainWindowTableLayoutPanel1.Controls.Add(this.MainWindowTableLayoutPanel2, 0, 2);
            this.MainWindowTableLayoutPanel1.Controls.Add(this.MainWindowTableLayoutPanel3, 0, 1);
            this.MainWindowTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.MainWindowTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowTableLayoutPanel1.Name = "MainWindowTableLayoutPanel1";
            this.MainWindowTableLayoutPanel1.RowCount = 3;
            this.MainWindowTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTableLayoutPanel1.Size = new System.Drawing.Size(1574, 1529);
            this.MainWindowTableLayoutPanel1.TabIndex = 0;
            // 
            // MainWindowMenuStrip
            // 
            this.MainWindowMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainWindowMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainWindowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.BookmarksToolStripMenuItem,
            this.TestingToolStripMenuItem});
            this.MainWindowMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindowMenuStrip.Name = "MainWindowMenuStrip";
            this.MainWindowMenuStrip.Size = new System.Drawing.Size(1574, 48);
            this.MainWindowMenuStrip.TabIndex = 0;
            this.MainWindowMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // BookmarksToolStripMenuItem
            // 
            this.BookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem";
            this.BookmarksToolStripMenuItem.Size = new System.Drawing.Size(151, 38);
            this.BookmarksToolStripMenuItem.Text = "Bookmarks";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(198, 44);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(198, 44);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // TestingToolStripMenuItem
            // 
            this.TestingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunTestToolStripMenuItem});
            this.TestingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TestingToolStripMenuItem.Name = "TestingToolStripMenuItem";
            this.TestingToolStripMenuItem.Size = new System.Drawing.Size(110, 38);
            this.TestingToolStripMenuItem.Text = "Testing";
            // 
            // RunTestToolStripMenuItem
            // 
            this.RunTestToolStripMenuItem.Name = "RunTestToolStripMenuItem";
            this.RunTestToolStripMenuItem.Size = new System.Drawing.Size(238, 44);
            this.RunTestToolStripMenuItem.Text = "Run Test";
            this.RunTestToolStripMenuItem.Click += new System.EventHandler(this.RunTestToolStripMenuItem_Click);
            // 
            // MainWindowTableLayoutPanel2
            // 
            this.MainWindowTableLayoutPanel2.AutoSize = true;
            this.MainWindowTableLayoutPanel2.ColumnCount = 1;
            this.MainWindowTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainWindowTableLayoutPanel2.Controls.Add(this.MainWindowTabControl, 0, 0);
            this.MainWindowTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTableLayoutPanel2.Location = new System.Drawing.Point(4, 141);
            this.MainWindowTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowTableLayoutPanel2.Name = "MainWindowTableLayoutPanel2";
            this.MainWindowTableLayoutPanel2.RowCount = 1;
            this.MainWindowTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowTableLayoutPanel2.Size = new System.Drawing.Size(1566, 1398);
            this.MainWindowTableLayoutPanel2.TabIndex = 2;
            // 
            // MainWindowTabControl
            // 
            this.MainWindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTabControl.Location = new System.Drawing.Point(4, 4);
            this.MainWindowTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowTabControl.Name = "MainWindowTabControl";
            this.MainWindowTabControl.SelectedIndex = 0;
            this.MainWindowTabControl.Size = new System.Drawing.Size(1558, 1390);
            this.MainWindowTabControl.TabIndex = 6;
            this.MainWindowTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainWindowTabControl_DrawItem);
            this.MainWindowTabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindowTabControl_MouseUp);
            // 
            // MainWindowTableLayoutPanel3
            // 
            this.MainWindowTableLayoutPanel3.AutoSize = true;
            this.MainWindowTableLayoutPanel3.ColumnCount = 2;
            this.MainWindowTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.60714F));
            this.MainWindowTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.39286F));
            this.MainWindowTableLayoutPanel3.Controls.Add(this.MainWindowFlowLayoutPanel1, 0, 0);
            this.MainWindowTableLayoutPanel3.Controls.Add(this.MainWindowFlowLayoutPanel2, 1, 0);
            this.MainWindowTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTableLayoutPanel3.Location = new System.Drawing.Point(3, 51);
            this.MainWindowTableLayoutPanel3.Name = "MainWindowTableLayoutPanel3";
            this.MainWindowTableLayoutPanel3.RowCount = 1;
            this.MainWindowTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainWindowTableLayoutPanel3.Size = new System.Drawing.Size(1568, 83);
            this.MainWindowTableLayoutPanel3.TabIndex = 3;
            // 
            // MainWindowFlowLayoutPanel1
            // 
            this.MainWindowFlowLayoutPanel1.AutoSize = true;
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowBackButton);
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowForwardButton);
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowReloadButton);
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowURLBar);
            this.MainWindowFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowFlowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.MainWindowFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowFlowLayoutPanel1.Name = "MainWindowFlowLayoutPanel1";
            this.MainWindowFlowLayoutPanel1.Size = new System.Drawing.Size(1350, 75);
            this.MainWindowFlowLayoutPanel1.TabIndex = 1;
            this.MainWindowFlowLayoutPanel1.WrapContents = false;
            // 
            // MainWindowBackButton
            // 
            this.MainWindowBackButton.AutoSize = true;
            this.MainWindowBackButton.FlatAppearance.BorderSize = 0;
            this.MainWindowBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainWindowBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWindowBackButton.Location = new System.Drawing.Point(4, 4);
            this.MainWindowBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowBackButton.Name = "MainWindowBackButton";
            this.MainWindowBackButton.Size = new System.Drawing.Size(68, 67);
            this.MainWindowBackButton.TabIndex = 1;
            this.MainWindowBackButton.Text = "<";
            this.MainWindowBackButton.UseVisualStyleBackColor = true;
            this.MainWindowBackButton.Click += new System.EventHandler(this.MainWindowBackButton_Click);
            // 
            // MainWindowForwardButton
            // 
            this.MainWindowForwardButton.AutoSize = true;
            this.MainWindowForwardButton.FlatAppearance.BorderSize = 0;
            this.MainWindowForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainWindowForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWindowForwardButton.Location = new System.Drawing.Point(80, 4);
            this.MainWindowForwardButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowForwardButton.Name = "MainWindowForwardButton";
            this.MainWindowForwardButton.Size = new System.Drawing.Size(68, 67);
            this.MainWindowForwardButton.TabIndex = 2;
            this.MainWindowForwardButton.Text = ">";
            this.MainWindowForwardButton.UseVisualStyleBackColor = true;
            this.MainWindowForwardButton.Click += new System.EventHandler(this.MainWindowForwardButton_Click);
            // 
            // MainWindowReloadButton
            // 
            this.MainWindowReloadButton.AutoSize = true;
            this.MainWindowReloadButton.FlatAppearance.BorderSize = 0;
            this.MainWindowReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainWindowReloadButton.Location = new System.Drawing.Point(156, 4);
            this.MainWindowReloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowReloadButton.Name = "MainWindowReloadButton";
            this.MainWindowReloadButton.Size = new System.Drawing.Size(74, 67);
            this.MainWindowReloadButton.TabIndex = 3;
            this.MainWindowReloadButton.Text = "R";
            this.MainWindowReloadButton.UseVisualStyleBackColor = true;
            this.MainWindowReloadButton.Click += new System.EventHandler(this.MainWindowReloadButton_Click);
            // 
            // MainWindowURLBar
            // 
            this.MainWindowURLBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWindowURLBar.Location = new System.Drawing.Point(238, 16);
            this.MainWindowURLBar.Margin = new System.Windows.Forms.Padding(4, 16, 4, 4);
            this.MainWindowURLBar.Name = "MainWindowURLBar";
            this.MainWindowURLBar.Size = new System.Drawing.Size(833, 40);
            this.MainWindowURLBar.TabIndex = 4;
            this.MainWindowURLBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindowURLBar_KeyPress);
            // 
            // MainWindowFlowLayoutPanel2
            // 
            this.MainWindowFlowLayoutPanel2.AutoSize = true;
            this.MainWindowFlowLayoutPanel2.Controls.Add(this.MainWindowNewTabButton);
            this.MainWindowFlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowFlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.MainWindowFlowLayoutPanel2.Location = new System.Drawing.Point(1361, 3);
            this.MainWindowFlowLayoutPanel2.Name = "MainWindowFlowLayoutPanel2";
            this.MainWindowFlowLayoutPanel2.Size = new System.Drawing.Size(204, 77);
            this.MainWindowFlowLayoutPanel2.TabIndex = 2;
            // 
            // MainWindowNewTabButton
            // 
            this.MainWindowNewTabButton.AutoSize = true;
            this.MainWindowNewTabButton.FlatAppearance.BorderSize = 0;
            this.MainWindowNewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainWindowNewTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWindowNewTabButton.Location = new System.Drawing.Point(132, 4);
            this.MainWindowNewTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowNewTabButton.Name = "MainWindowNewTabButton";
            this.MainWindowNewTabButton.Size = new System.Drawing.Size(68, 67);
            this.MainWindowNewTabButton.TabIndex = 5;
            this.MainWindowNewTabButton.Text = "+";
            this.MainWindowNewTabButton.UseVisualStyleBackColor = true;
            this.MainWindowNewTabButton.Click += new System.EventHandler(this.MainWindowNewTabButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1574, 1529);
            this.Controls.Add(this.MainWindowTableLayoutPanel1);
            this.MainMenuStrip = this.MainWindowMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Brother Browser";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainWindowTableLayoutPanel1.ResumeLayout(false);
            this.MainWindowTableLayoutPanel1.PerformLayout();
            this.MainWindowMenuStrip.ResumeLayout(false);
            this.MainWindowMenuStrip.PerformLayout();
            this.MainWindowTableLayoutPanel2.ResumeLayout(false);
            this.MainWindowTableLayoutPanel3.ResumeLayout(false);
            this.MainWindowTableLayoutPanel3.PerformLayout();
            this.MainWindowFlowLayoutPanel1.ResumeLayout(false);
            this.MainWindowFlowLayoutPanel1.PerformLayout();
            this.MainWindowFlowLayoutPanel2.ResumeLayout(false);
            this.MainWindowFlowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainWindowTableLayoutPanel1;
        private System.Windows.Forms.MenuStrip MainWindowMenuStrip;
        private System.Windows.Forms.FlowLayoutPanel MainWindowFlowLayoutPanel1;
        private System.Windows.Forms.Button MainWindowBackButton;
        private System.Windows.Forms.Button MainWindowForwardButton;
        private System.Windows.Forms.Button MainWindowReloadButton;
        private System.Windows.Forms.TextBox MainWindowURLBar;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookmarksToolStripMenuItem;
        private System.Windows.Forms.Button MainWindowNewTabButton;
        private System.Windows.Forms.TableLayoutPanel MainWindowTableLayoutPanel2;
        private System.Windows.Forms.TabControl MainWindowTabControl;
        private System.Windows.Forms.ToolStripMenuItem TestingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel MainWindowTableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel MainWindowFlowLayoutPanel2;
    }
}

