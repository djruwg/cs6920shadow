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
            MainWindowTableLayoutPanel1 = new TableLayoutPanel();
            MainWindowMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            RunNewTabToolStripMenuItem = new ToolStripMenuItem();
            RunPrintMenuToolStripItem = new ToolStripMenuItem();
            RunQuitToolStripMenuItem = new ToolStripMenuItem();
            BookmarksToolStripMenuItem = new ToolStripMenuItem();
            TeacherToolStripMenuItem = new ToolStripMenuItem();
            RunUnlockToolStripMenuItem = new ToolStripMenuItem();
            RunManageBlockListToolStripMenuItem = new ToolStripMenuItem();
            RunManageBookmarksToolStripMenuItem = new ToolStripMenuItem();
            ToolsToolStripMenuItem = new ToolStripMenuItem();
            RunTestToolStripMenuItem = new ToolStripMenuItem();
            RunDeveloperToolsMenuItem = new ToolStripMenuItem();
            RunTaskManagerToolStripMenuItem = new ToolStripMenuItem();
            RunRestWorkSpaceToolStripMenuItem = new ToolStripMenuItem();
            MainWindowTableLayoutPanel2 = new TableLayoutPanel();
            MainWindowTabControl = new TabControl();
            MainWindowTableLayoutPanel3 = new TableLayoutPanel();
            MainWindowFlowLayoutPanel1 = new FlowLayoutPanel();
            MainWindowBackButton = new Button();
            MainWindowForwardButton = new Button();
            MainWindowReloadButton = new Button();
            MainWindowURLBar = new TextBox();
            MainWindowFlowLayoutPanel2 = new FlowLayoutPanel();
            MainWindowNewTabButton = new Button();
            MainWindowTableLayoutPanel1.SuspendLayout();
            MainWindowMenuStrip.SuspendLayout();
            MainWindowTableLayoutPanel2.SuspendLayout();
            MainWindowTableLayoutPanel3.SuspendLayout();
            MainWindowFlowLayoutPanel1.SuspendLayout();
            MainWindowFlowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainWindowTableLayoutPanel1
            // 
            MainWindowTableLayoutPanel1.AutoSize = true;
            MainWindowTableLayoutPanel1.ColumnCount = 1;
            MainWindowTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainWindowTableLayoutPanel1.Controls.Add(MainWindowMenuStrip, 0, 0);
            MainWindowTableLayoutPanel1.Controls.Add(MainWindowTableLayoutPanel2, 0, 2);
            MainWindowTableLayoutPanel1.Controls.Add(MainWindowTableLayoutPanel3, 0, 1);
            MainWindowTableLayoutPanel1.Dock = DockStyle.Fill;
            MainWindowTableLayoutPanel1.Location = new Point(0, 0);
            MainWindowTableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            MainWindowTableLayoutPanel1.Name = "MainWindowTableLayoutPanel1";
            MainWindowTableLayoutPanel1.RowCount = 3;
            MainWindowTableLayoutPanel1.RowStyles.Add(new RowStyle());
            MainWindowTableLayoutPanel1.RowStyles.Add(new RowStyle());
            MainWindowTableLayoutPanel1.RowStyles.Add(new RowStyle());
            MainWindowTableLayoutPanel1.Size = new Size(1705, 1771);
            MainWindowTableLayoutPanel1.TabIndex = 0;
            // 
            // MainWindowMenuStrip
            // 
            MainWindowMenuStrip.ImageScalingSize = new Size(32, 32);
            MainWindowMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, BookmarksToolStripMenuItem, TeacherToolStripMenuItem, ToolsToolStripMenuItem });
            MainWindowMenuStrip.Location = new Point(0, 0);
            MainWindowMenuStrip.Name = "MainWindowMenuStrip";
            MainWindowMenuStrip.Padding = new Padding(6, 3, 0, 3);
            MainWindowMenuStrip.Size = new Size(1705, 44);
            MainWindowMenuStrip.TabIndex = 0;
            MainWindowMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RunNewTabToolStripMenuItem, RunPrintMenuToolStripItem, RunQuitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(71, 38);
            FileToolStripMenuItem.Text = "File";
            // 
            // RunNewTabToolStripMenuItem
            // 
            RunNewTabToolStripMenuItem.Name = "RunNewTabToolStripMenuItem";
            RunNewTabToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            RunNewTabToolStripMenuItem.Size = new Size(359, 44);
            RunNewTabToolStripMenuItem.Text = "New Tab";
            RunNewTabToolStripMenuItem.Click += RunNewTabToolStripMenuItem_Click;
            // 
            // RunPrintMenuToolStripItem
            // 
            RunPrintMenuToolStripItem.Name = "RunPrintMenuToolStripItem";
            RunPrintMenuToolStripItem.ShortcutKeys = Keys.Control | Keys.P;
            RunPrintMenuToolStripItem.Size = new Size(359, 44);
            RunPrintMenuToolStripItem.Text = "Print";
            RunPrintMenuToolStripItem.Click += RunPrintMenuToolStripItem_Click;
            // 
            // RunQuitToolStripMenuItem
            // 
            RunQuitToolStripMenuItem.Name = "RunQuitToolStripMenuItem";
            RunQuitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            RunQuitToolStripMenuItem.Size = new Size(359, 44);
            RunQuitToolStripMenuItem.Text = "Quit";
            RunQuitToolStripMenuItem.Click += RunQuitToolStripMenuItem_Click;
            // 
            // BookmarksToolStripMenuItem
            // 
            BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem";
            BookmarksToolStripMenuItem.Size = new Size(151, 38);
            BookmarksToolStripMenuItem.Text = "Bookmarks";
            BookmarksToolStripMenuItem.Click += BookmarksToolStripMenuItem_Click;
            // 
            // TeacherToolStripMenuItem
            // 
            TeacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RunUnlockToolStripMenuItem, RunManageBlockListToolStripMenuItem, RunManageBookmarksToolStripMenuItem });
            TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem";
            TeacherToolStripMenuItem.Size = new Size(116, 38);
            TeacherToolStripMenuItem.Text = "Teacher";
            // 
            // RunUnlockToolStripMenuItem
            // 
            RunUnlockToolStripMenuItem.Name = "RunUnlockToolStripMenuItem";
            RunUnlockToolStripMenuItem.Size = new Size(358, 44);
            RunUnlockToolStripMenuItem.Text = "Unlock";
            RunUnlockToolStripMenuItem.Click += unlockToolStripMenuItem_Click;
            // 
            // RunManageBlockListToolStripMenuItem
            // 
            RunManageBlockListToolStripMenuItem.Name = "RunManageBlockListToolStripMenuItem";
            RunManageBlockListToolStripMenuItem.Size = new Size(358, 44);
            RunManageBlockListToolStripMenuItem.Text = "Manage Block List";
            RunManageBlockListToolStripMenuItem.Click += manageBlockListToolStripMenuItem_Click;
            // 
            // RunManageBookmarksToolStripMenuItem
            // 
            RunManageBookmarksToolStripMenuItem.Name = "RunManageBookmarksToolStripMenuItem";
            RunManageBookmarksToolStripMenuItem.Size = new Size(358, 44);
            RunManageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
            RunManageBookmarksToolStripMenuItem.Click += manageBookmarksToolStripMenuItem_Click;
            // 
            // ToolsToolStripMenuItem
            // 
            ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RunTestToolStripMenuItem, RunDeveloperToolsMenuItem, RunTaskManagerToolStripMenuItem, RunRestWorkSpaceToolStripMenuItem });
            ToolsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            ToolsToolStripMenuItem.Size = new Size(89, 38);
            ToolsToolStripMenuItem.Text = "Tools";
            // 
            // RunTestToolStripMenuItem
            // 
            RunTestToolStripMenuItem.Name = "RunTestToolStripMenuItem";
            RunTestToolStripMenuItem.Size = new Size(403, 44);
            RunTestToolStripMenuItem.Text = "Run Test";
            RunTestToolStripMenuItem.Click += RunTestToolStripMenuItem_Click;
            // 
            // RunDeveloperToolsMenuItem
            // 
            RunDeveloperToolsMenuItem.Name = "RunDeveloperToolsMenuItem";
            RunDeveloperToolsMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            RunDeveloperToolsMenuItem.Size = new Size(403, 44);
            RunDeveloperToolsMenuItem.Text = "Developer Tools";
            RunDeveloperToolsMenuItem.Click += RunDeveloperToolsMenuItem_Click;
            // 
            // RunTaskManagerToolStripMenuItem
            // 
            RunTaskManagerToolStripMenuItem.Name = "RunTaskManagerToolStripMenuItem";
            RunTaskManagerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            RunTaskManagerToolStripMenuItem.Size = new Size(403, 44);
            RunTaskManagerToolStripMenuItem.Text = "Task Manager";
            RunTaskManagerToolStripMenuItem.Click += RunTaskManagerToolStripMenuItem_Click;
            // 
            // RunRestWorkSpaceToolStripMenuItem
            // 
            RunRestWorkSpaceToolStripMenuItem.Name = "RunRestWorkSpaceToolStripMenuItem";
            RunRestWorkSpaceToolStripMenuItem.Size = new Size(403, 44);
            RunRestWorkSpaceToolStripMenuItem.Text = "Rest Work Space";
            RunRestWorkSpaceToolStripMenuItem.Click += restWorkSpaceToolStripMenuItem_Click;
            // 
            // MainWindowTableLayoutPanel2
            // 
            MainWindowTableLayoutPanel2.AutoSize = true;
            MainWindowTableLayoutPanel2.ColumnCount = 1;
            MainWindowTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            MainWindowTableLayoutPanel2.Controls.Add(MainWindowTabControl, 0, 0);
            MainWindowTableLayoutPanel2.Dock = DockStyle.Fill;
            MainWindowTableLayoutPanel2.Location = new Point(4, 163);
            MainWindowTableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            MainWindowTableLayoutPanel2.Name = "MainWindowTableLayoutPanel2";
            MainWindowTableLayoutPanel2.RowCount = 1;
            MainWindowTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainWindowTableLayoutPanel2.Size = new Size(1697, 1789);
            MainWindowTableLayoutPanel2.TabIndex = 2;
            // 
            // MainWindowTabControl
            // 
            MainWindowTabControl.Dock = DockStyle.Fill;
            MainWindowTabControl.Location = new Point(4, 5);
            MainWindowTabControl.Margin = new Padding(4, 5, 4, 5);
            MainWindowTabControl.Name = "MainWindowTabControl";
            MainWindowTabControl.SelectedIndex = 0;
            MainWindowTabControl.Size = new Size(1689, 1779);
            MainWindowTabControl.TabIndex = 6;
            MainWindowTabControl.DrawItem += MainWindowTabControl_DrawItem;
            MainWindowTabControl.MouseUp += MainWindowTabControl_MouseUp;
            // 
            // MainWindowTableLayoutPanel3
            // 
            MainWindowTableLayoutPanel3.AutoSize = true;
            MainWindowTableLayoutPanel3.ColumnCount = 2;
            MainWindowTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainWindowTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            MainWindowTableLayoutPanel3.Controls.Add(MainWindowFlowLayoutPanel1, 0, 0);
            MainWindowTableLayoutPanel3.Controls.Add(MainWindowFlowLayoutPanel2, 1, 0);
            MainWindowTableLayoutPanel3.Dock = DockStyle.Fill;
            MainWindowTableLayoutPanel3.Location = new Point(3, 48);
            MainWindowTableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            MainWindowTableLayoutPanel3.Name = "MainWindowTableLayoutPanel3";
            MainWindowTableLayoutPanel3.RowCount = 1;
            MainWindowTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainWindowTableLayoutPanel3.Size = new Size(1699, 106);
            MainWindowTableLayoutPanel3.TabIndex = 3;
            // 
            // MainWindowFlowLayoutPanel1
            // 
            MainWindowFlowLayoutPanel1.AutoSize = true;
            MainWindowFlowLayoutPanel1.Controls.Add(MainWindowBackButton);
            MainWindowFlowLayoutPanel1.Controls.Add(MainWindowForwardButton);
            MainWindowFlowLayoutPanel1.Controls.Add(MainWindowReloadButton);
            MainWindowFlowLayoutPanel1.Controls.Add(MainWindowURLBar);
            MainWindowFlowLayoutPanel1.Dock = DockStyle.Fill;
            MainWindowFlowLayoutPanel1.Location = new Point(4, 5);
            MainWindowFlowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            MainWindowFlowLayoutPanel1.Name = "MainWindowFlowLayoutPanel1";
            MainWindowFlowLayoutPanel1.Size = new Size(1603, 96);
            MainWindowFlowLayoutPanel1.TabIndex = 1;
            MainWindowFlowLayoutPanel1.WrapContents = false;
            // 
            // MainWindowBackButton
            // 
            MainWindowBackButton.AutoSize = true;
            MainWindowBackButton.FlatAppearance.BorderSize = 0;
            MainWindowBackButton.FlatStyle = FlatStyle.Flat;
            MainWindowBackButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainWindowBackButton.Location = new Point(4, 5);
            MainWindowBackButton.Margin = new Padding(4, 5, 4, 5);
            MainWindowBackButton.Name = "MainWindowBackButton";
            MainWindowBackButton.Size = new Size(74, 86);
            MainWindowBackButton.TabIndex = 1;
            MainWindowBackButton.Text = "<";
            MainWindowBackButton.UseVisualStyleBackColor = true;
            MainWindowBackButton.Click += MainWindowBackButton_Click;
            // 
            // MainWindowForwardButton
            // 
            MainWindowForwardButton.AutoSize = true;
            MainWindowForwardButton.FlatAppearance.BorderSize = 0;
            MainWindowForwardButton.FlatStyle = FlatStyle.Flat;
            MainWindowForwardButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainWindowForwardButton.Location = new Point(86, 5);
            MainWindowForwardButton.Margin = new Padding(4, 5, 4, 5);
            MainWindowForwardButton.Name = "MainWindowForwardButton";
            MainWindowForwardButton.Size = new Size(74, 86);
            MainWindowForwardButton.TabIndex = 2;
            MainWindowForwardButton.Text = ">";
            MainWindowForwardButton.UseVisualStyleBackColor = true;
            MainWindowForwardButton.Click += MainWindowForwardButton_Click;
            // 
            // MainWindowReloadButton
            // 
            MainWindowReloadButton.AutoSize = true;
            MainWindowReloadButton.BackgroundImage = Properties.Resources.refresh;
            MainWindowReloadButton.BackgroundImageLayout = ImageLayout.Center;
            MainWindowReloadButton.FlatAppearance.BorderSize = 0;
            MainWindowReloadButton.FlatStyle = FlatStyle.Flat;
            MainWindowReloadButton.Location = new Point(168, 5);
            MainWindowReloadButton.Margin = new Padding(4, 5, 4, 5);
            MainWindowReloadButton.Name = "MainWindowReloadButton";
            MainWindowReloadButton.Size = new Size(80, 86);
            MainWindowReloadButton.TabIndex = 3;
            MainWindowReloadButton.UseVisualStyleBackColor = true;
            MainWindowReloadButton.Click += MainWindowReloadButton_Click;
            // 
            // MainWindowURLBar
            // 
            MainWindowURLBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainWindowURLBar.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainWindowURLBar.Location = new Point(256, 28);
            MainWindowURLBar.Margin = new Padding(4, 28, 4, 1);
            MainWindowURLBar.Name = "MainWindowURLBar";
            MainWindowURLBar.Size = new Size(1322, 40);
            MainWindowURLBar.TabIndex = 4;
            MainWindowURLBar.KeyPress += MainWindowURLBar_KeyPress;
            // 
            // MainWindowFlowLayoutPanel2
            // 
            MainWindowFlowLayoutPanel2.AutoSize = true;
            MainWindowFlowLayoutPanel2.Controls.Add(MainWindowNewTabButton);
            MainWindowFlowLayoutPanel2.Dock = DockStyle.Fill;
            MainWindowFlowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            MainWindowFlowLayoutPanel2.Location = new Point(1614, 4);
            MainWindowFlowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            MainWindowFlowLayoutPanel2.Name = "MainWindowFlowLayoutPanel2";
            MainWindowFlowLayoutPanel2.Size = new Size(82, 98);
            MainWindowFlowLayoutPanel2.TabIndex = 2;
            // 
            // MainWindowNewTabButton
            // 
            MainWindowNewTabButton.AutoSize = true;
            MainWindowNewTabButton.FlatAppearance.BorderSize = 0;
            MainWindowNewTabButton.FlatStyle = FlatStyle.Flat;
            MainWindowNewTabButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainWindowNewTabButton.Location = new Point(4, 5);
            MainWindowNewTabButton.Margin = new Padding(4, 5, 4, 5);
            MainWindowNewTabButton.Name = "MainWindowNewTabButton";
            MainWindowNewTabButton.Size = new Size(74, 86);
            MainWindowNewTabButton.TabIndex = 5;
            MainWindowNewTabButton.Text = "+";
            MainWindowNewTabButton.UseVisualStyleBackColor = true;
            MainWindowNewTabButton.Click += MainWindowNewTabButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1705, 1771);
            Controls.Add(MainWindowTableLayoutPanel1);
            MainMenuStrip = MainWindowMenuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Big Brother Browser";
            Load += MainWindow_Load;
            MainWindowTableLayoutPanel1.ResumeLayout(false);
            MainWindowTableLayoutPanel1.PerformLayout();
            MainWindowMenuStrip.ResumeLayout(false);
            MainWindowMenuStrip.PerformLayout();
            MainWindowTableLayoutPanel2.ResumeLayout(false);
            MainWindowTableLayoutPanel3.ResumeLayout(false);
            MainWindowTableLayoutPanel3.PerformLayout();
            MainWindowFlowLayoutPanel1.ResumeLayout(false);
            MainWindowFlowLayoutPanel1.PerformLayout();
            MainWindowFlowLayoutPanel2.ResumeLayout(false);
            MainWindowFlowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunTestToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel MainWindowTableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel MainWindowFlowLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem RunDeveloperToolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunTaskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunPrintMenuToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem RunRestWorkSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunUnlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunManageBlockListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunManageBookmarksToolStripMenuItem;
        private ToolStripMenuItem RunNewTabToolStripMenuItem;
        private ToolStripMenuItem RunQuitToolStripMenuItem;
    }
}

