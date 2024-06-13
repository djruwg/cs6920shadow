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
            this.MainWindowFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainWindowBackButton = new System.Windows.Forms.Button();
            this.MainWindowForwardButton = new System.Windows.Forms.Button();
            this.MainWindowReloadButton = new System.Windows.Forms.Button();
            this.MainWindowURLBar = new System.Windows.Forms.TextBox();
            this.MainWindowNewTabButton = new System.Windows.Forms.Button();
            this.MainWindowTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MainWindowTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainWindowTableLayoutPanel1.SuspendLayout();
            this.MainWindowMenuStrip.SuspendLayout();
            this.MainWindowFlowLayoutPanel1.SuspendLayout();
            this.MainWindowTableLayoutPanel2.SuspendLayout();
            this.MainWindowTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowTableLayoutPanel1
            // 
            this.MainWindowTableLayoutPanel1.AutoSize = true;
            this.MainWindowTableLayoutPanel1.ColumnCount = 1;
            this.MainWindowTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowTableLayoutPanel1.Controls.Add(this.MainWindowMenuStrip, 0, 0);
            this.MainWindowTableLayoutPanel1.Controls.Add(this.MainWindowFlowLayoutPanel1, 0, 1);
            this.MainWindowTableLayoutPanel1.Controls.Add(this.MainWindowTableLayoutPanel2, 0, 2);
            this.MainWindowTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.MainWindowTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowTableLayoutPanel1.Name = "MainWindowTableLayoutPanel1";
            this.MainWindowTableLayoutPanel1.RowCount = 3;
            this.MainWindowTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTableLayoutPanel1.Size = new System.Drawing.Size(587, 461);
            this.MainWindowTableLayoutPanel1.TabIndex = 0;
            // 
            // MainWindowMenuStrip
            // 
            this.MainWindowMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainWindowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.BookmarksToolStripMenuItem,
            this.TestingToolStripMenuItem});
            this.MainWindowMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainWindowMenuStrip.Name = "MainWindowMenuStrip";
            this.MainWindowMenuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.MainWindowMenuStrip.Size = new System.Drawing.Size(587, 24);
            this.MainWindowMenuStrip.TabIndex = 0;
            this.MainWindowMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // BookmarksToolStripMenuItem
            // 
            this.BookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem";
            this.BookmarksToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.BookmarksToolStripMenuItem.Text = "Bookmarks";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // TestingToolStripMenuItem
            // 
            this.TestingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunTestToolStripMenuItem});
            this.TestingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TestingToolStripMenuItem.Name = "TestingToolStripMenuItem";
            this.TestingToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.TestingToolStripMenuItem.Text = "Testing";
            // 
            // RunTestToolStripMenuItem
            // 
            this.RunTestToolStripMenuItem.Name = "RunTestToolStripMenuItem";
            this.RunTestToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.RunTestToolStripMenuItem.Text = "Run Test";
            this.RunTestToolStripMenuItem.Click += new System.EventHandler(this.RunTestToolStripMenuItem_Click);
            // 
            // MainWindowFlowLayoutPanel1
            // 
            this.MainWindowFlowLayoutPanel1.AutoSize = true;
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowBackButton);
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowForwardButton);
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowReloadButton);
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowURLBar);
            this.MainWindowFlowLayoutPanel1.Controls.Add(this.MainWindowNewTabButton);
            this.MainWindowFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowFlowLayoutPanel1.Location = new System.Drawing.Point(2, 26);
            this.MainWindowFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowFlowLayoutPanel1.Name = "MainWindowFlowLayoutPanel1";
            this.MainWindowFlowLayoutPanel1.Size = new System.Drawing.Size(583, 27);
            this.MainWindowFlowLayoutPanel1.TabIndex = 1;
            this.MainWindowFlowLayoutPanel1.WrapContents = false;
            // 
            // MainWindowBackButton
            // 
            this.MainWindowBackButton.AutoSize = true;
            this.MainWindowBackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowBackButton.Location = new System.Drawing.Point(2, 2);
            this.MainWindowBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowBackButton.Name = "MainWindowBackButton";
            this.MainWindowBackButton.Size = new System.Drawing.Size(32, 23);
            this.MainWindowBackButton.TabIndex = 0;
            this.MainWindowBackButton.Text = "<";
            this.MainWindowBackButton.UseVisualStyleBackColor = true;
            // 
            // MainWindowForwardButton
            // 
            this.MainWindowForwardButton.AutoSize = true;
            this.MainWindowForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowForwardButton.Location = new System.Drawing.Point(38, 2);
            this.MainWindowForwardButton.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowForwardButton.Name = "MainWindowForwardButton";
            this.MainWindowForwardButton.Size = new System.Drawing.Size(32, 23);
            this.MainWindowForwardButton.TabIndex = 1;
            this.MainWindowForwardButton.Text = ">";
            this.MainWindowForwardButton.UseVisualStyleBackColor = true;
            // 
            // MainWindowReloadButton
            // 
            this.MainWindowReloadButton.AutoSize = true;
            this.MainWindowReloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowReloadButton.Location = new System.Drawing.Point(74, 2);
            this.MainWindowReloadButton.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowReloadButton.Name = "MainWindowReloadButton";
            this.MainWindowReloadButton.Size = new System.Drawing.Size(32, 23);
            this.MainWindowReloadButton.TabIndex = 2;
            this.MainWindowReloadButton.Text = "R";
            this.MainWindowReloadButton.UseVisualStyleBackColor = true;
            // 
            // MainWindowURLBar
            // 
            this.MainWindowURLBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowURLBar.Location = new System.Drawing.Point(110, 2);
            this.MainWindowURLBar.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowURLBar.Name = "MainWindowURLBar";
            this.MainWindowURLBar.Size = new System.Drawing.Size(434, 20);
            this.MainWindowURLBar.TabIndex = 3;
            // 
            // MainWindowNewTabButton
            // 
            this.MainWindowNewTabButton.AutoSize = true;
            this.MainWindowNewTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowNewTabButton.Location = new System.Drawing.Point(548, 2);
            this.MainWindowNewTabButton.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowNewTabButton.Name = "MainWindowNewTabButton";
            this.MainWindowNewTabButton.Size = new System.Drawing.Size(32, 23);
            this.MainWindowNewTabButton.TabIndex = 4;
            this.MainWindowNewTabButton.Text = "+";
            this.MainWindowNewTabButton.UseVisualStyleBackColor = true;
            this.MainWindowNewTabButton.Click += new System.EventHandler(this.MainWindowNewTabButton_Click);

            // 
            // MainWindowTableLayoutPanel2
            // 
            this.MainWindowTableLayoutPanel2.AutoSize = true;
            this.MainWindowTableLayoutPanel2.ColumnCount = 1;
            this.MainWindowTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainWindowTableLayoutPanel2.Controls.Add(this.MainWindowTabControl, 0, 0);
            this.MainWindowTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTableLayoutPanel2.Location = new System.Drawing.Point(2, 57);
            this.MainWindowTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowTableLayoutPanel2.Name = "MainWindowTableLayoutPanel2";
            this.MainWindowTableLayoutPanel2.RowCount = 1;
            this.MainWindowTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowTableLayoutPanel2.Size = new System.Drawing.Size(583, 548);
            this.MainWindowTableLayoutPanel2.TabIndex = 2;
            // 
            // MainWindowTabControl
            // 
            this.MainWindowTabControl.Controls.Add(this.tabPage1);
            this.MainWindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowTabControl.Location = new System.Drawing.Point(2, 2);
            this.MainWindowTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainWindowTabControl.Name = "MainWindowTabControl";
            this.MainWindowTabControl.SelectedIndex = 0;
            this.MainWindowTabControl.Size = new System.Drawing.Size(581, 544);
            this.MainWindowTabControl.TabIndex = 0;
            this.MainWindowTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainWindowTabControl_DrawItem);
            this.MainWindowTabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindowTabControl_MouseUp);

            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(573, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 461);
            this.Controls.Add(this.MainWindowTableLayoutPanel1);
            this.MainMenuStrip = this.MainWindowMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Brother Browser";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainWindowTableLayoutPanel1.ResumeLayout(false);
            this.MainWindowTableLayoutPanel1.PerformLayout();
            this.MainWindowMenuStrip.ResumeLayout(false);
            this.MainWindowMenuStrip.PerformLayout();
            this.MainWindowFlowLayoutPanel1.ResumeLayout(false);
            this.MainWindowFlowLayoutPanel1.PerformLayout();
            this.MainWindowTableLayoutPanel2.ResumeLayout(false);
            this.MainWindowTabControl.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem TestingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}

