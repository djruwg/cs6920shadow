using BBB.ClientRESTHelpers;
using BBB.Controllers;
using BBB.Helpers;
using BBB.UserControls;
using BBB.Views;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BBB
{
    public partial class MainWindow : Form, RenderingUserControlInterface
    {
        private SettingsController _settingsController;

        private const int TAB_LEADING_SPACE = 8;
        private const int TAB_TRAILING_SPACE = 32;

        /// <summary>
        /// Compiled regular expression for validating URLs
        /// </summary>
        private static readonly Regex urlRegex = new Regex(@"^(https?|ftp)?(:\/\/)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}([\/\w .-]*)*\/?$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private Boolean teacherLocked = true;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this._settingsController = new SettingsController();

            teacherLocked = true;
        }

        /// <summary>
        /// Perform initial setup once this component has loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Image? image = MainWindowReloadButton.BackgroundImage;

            if (image != null)
            {
                Bitmap objBitmap = new Bitmap(image, new Size(28, 28));
                MainWindowReloadButton.BackgroundImage = objBitmap;
            }

            this.AdjustTabSizes();
            this.OpenNewTab();
        }

        /// <summary>
        /// Use this to invoke test code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // YOUR TEST CODE HERE
        }

        /// <summary>
        /// Launches the print dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunPrintMenuToolStripItem_Click(object sender, EventArgs e)
        {
            RenderingUserControl? renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                try
                {
                    renderingControl.OpenPrintDialog();
                }
                catch
                {
                    MessageBox.Show("Print Dialog Error", "Could not open the print dialog.");
                }
            }
        }

        /// <summary>
        /// Launches the developer tools window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunDeveloperToolsMenuItem_Click(object sender, EventArgs e)
        {
            RenderingUserControl? renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                try
                {
                    renderingControl.OpenDeveloperTools();
                }
                catch
                {
                    MessageBox.Show("Developer Tools Error", "Could not open the developer tools.");
                }
            }
        }

        private void RunTaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderingUserControl? renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                try
                {
                    renderingControl.OpenTaskManager();
                }
                catch
                {
                    MessageBox.Show("Task Manager Error", "Could not open the task manager.");
                }
            }
        }

        /// <summary>
        /// Returns the rendering user control of the currently selected tab
        /// </summary>
        /// <returns></returns>
        private RenderingUserControl? GetRenderingUserControl()
        {
            RenderingUserControl? renderingControl = null;

            if (MainWindowTabControl.SelectedIndex > -1)
            {
                Control control = MainWindowTabControl.TabPages[MainWindowTabControl.SelectedIndex].Controls[0];

                if (control is RenderingUserControl)
                {
                    renderingControl = (RenderingUserControl)control;
                }
            }

            return renderingControl;
        }

        /// <summary>
        /// Intercept the tab drawing routine and add an 'x' for closing tabs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rect = MainWindowTabControl.GetTabRect(e.Index);
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.Control), rect);
            e.Graphics.DrawString("x", e.Font ?? SystemFonts.DefaultFont, Brushes.Black, e.Bounds.Right - TAB_TRAILING_SPACE, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.MainWindowTabControl.TabPages[e.Index].Text,
                e.Font ?? SystemFonts.DefaultFont, Brushes.Black, e.Bounds.Left + TAB_LEADING_SPACE, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Adjust tab sizes to handle text and the closing 'x'.
        /// </summary>
        private void AdjustTabSizes()
        {
            MainWindowTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainWindowTabControl.SizeMode = TabSizeMode.Fixed;

            int tabLength = MainWindowTabControl.ItemSize.Width;

            for (int i = 0; i < MainWindowTabControl.TabPages.Count; i++)
            {
                TabPage currentPage = MainWindowTabControl.TabPages[i];
                int currentTabLength = TextRenderer.MeasureText(currentPage.Text, MainWindowTabControl.Font).Width;
                currentTabLength += TAB_LEADING_SPACE + TAB_TRAILING_SPACE;

                if (currentTabLength > tabLength)
                {
                    tabLength = currentTabLength;
                }
            }

            MainWindowTabControl.ItemSize = new Size(tabLength, MainWindowTabControl.ItemSize.Height);
        }

        /// <summary>
        /// Determine if the tab's 'x' was clicked and if so close the tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowTabControl_MouseUp(object sender, MouseEventArgs e)
        {
            int tabIndex = MainWindowTabControl.SelectedIndex;

            Rectangle closeButtonBounds = new Rectangle(
                MainWindowTabControl.GetTabRect(tabIndex).Right - TAB_TRAILING_SPACE,
                MainWindowTabControl.GetTabRect(tabIndex).Top, TAB_TRAILING_SPACE, MainWindowTabControl.ItemSize.Height);

            if (closeButtonBounds.Contains(e.Location))
            {
                MainWindowTabControl.Controls.Remove(MainWindowTabControl.TabPages[tabIndex]);
            }
            else
            {
                this.UpdateControlState();
            }
        }

        /// <summary>
        /// Handle click of new tab button and open a new tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowNewTabButton_Click(object sender, EventArgs e)
        {
            MainWindowNewTabButton.Enabled = false;

            this.OpenNewTab();
        }

        /// <summary>
        /// Open a new tab with a rendering user control.
        /// </summary>
        private void OpenNewTab()
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "New Tab";
            RenderingUserControl browser = new RenderingUserControl(this);
            browser.Dock = DockStyle.Fill;
            tabPage.Controls.Add(browser);
            MainWindowTabControl.Controls.Add(tabPage);
            this.AdjustTabSizes();
            MainWindowTabControl.SelectTab(tabPage);
            browser.GoToURL(this._settingsController.startupURL);
        }

        /// <summary>
        /// Listen for rendering user control events.
        /// </summary>
        public void RenderingUserControlEvent(object sender, EventArgs e)
        {
            Debug.WriteLine($"event {MainWindowTabControl.SelectedIndex}");
            this.UpdateControlState();
        }

        /// <summary>
        /// Updates the state of this form's controls based on the currently selected tab.
        /// </summary>
        private void UpdateControlState()
        {
            RenderingUserControl? renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                MainWindowBackButton.Enabled = renderingControl.CanGoBack();
                MainWindowForwardButton.Enabled = renderingControl.CanGoForward();
                MainWindowURLBar.Text = renderingControl.GetUrl();
                MainWindowTabControl.TabPages[MainWindowTabControl.SelectedIndex].Text = renderingControl.GetPageTitle().Truncate(16);
                this.AdjustTabSizes();
            }

            MainWindowNewTabButton.Enabled = true;
        }

        /// <summary>
        /// Instructs the currently selected rendering user control to navigate to the given URL.
        /// If the URL is not valid, it performs a google search on the URL bar contents.
        /// </summary>
        /// <param name="url">The URL to navigate to or the text to search</param>
        private void GoToURL(string url)
        {
            RenderingUserControl? renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                if (urlRegex.IsMatch(url))
                {
                    if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                    {
                        url = "http://" + url;
                    }
                    renderingControl.GoToURL(url);
                }
                else
                {
                    renderingControl.GoToURL($"https://www.google.com/search?q={url}");
                }
            }
        }

        /// <summary>
        /// On press of the enter key, requests the renderer navigate to the URL in the URL bar
        /// </summary>
        /// <param name="sender">the sending object</param>
        /// <param name="e">the key press event</param>
        private void MainWindowURLBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.GoToURL(MainWindowURLBar.Text);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handle back button click and go back a page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowBackButton_Click(object sender, EventArgs e)
        {
            RenderingUserControl? renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.GoBack();
            }
        }

        /// <summary>
        /// Handle forward button click and go forward a page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowForwardButton_Click(object sender, EventArgs e)
        {
            RenderingUserControl? renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.GoForward();
            }
        }

        /// <summary>
        /// Handle reload button click and reload the page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowReloadButton_Click(object sender, EventArgs e)
        {
            RenderingUserControl? renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.Reload();
            }
        }

        private void restWorkSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestWorkSpace restWorkSpace = new RestWorkSpace();
            restWorkSpace.Show();
        }

        private void unlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if (this.teacherLocked)
            {
                using (TeacherModeLogin login = new TeacherModeLogin())
                {
                    result = login.ShowDialog();
                }
                if (result == DialogResult.OK)
                {
                    RunManageBlockListToolStripMenuItem.Enabled = true;
                    RunManageBookmarksToolStripMenuItem.Enabled = true;
                    this.teacherLocked = false;
                    RunUnlockToolStripMenuItem.Text = "Lock";
                }
                else
                {
                    RunManageBlockListToolStripMenuItem.Enabled = false;
                    RunManageBookmarksToolStripMenuItem.Enabled = false;
                    this.teacherLocked = true;
                    RunUnlockToolStripMenuItem.Text = "Unlock";
                    BearerToken.Instance.Status = false;
                }
            }
            else
            {
                RunManageBlockListToolStripMenuItem.Enabled = false;
                RunManageBookmarksToolStripMenuItem.Enabled = false;
                RunUnlockToolStripMenuItem.Text = "Unlock";
                this.teacherLocked = true;
                BearerToken.Instance.Status = false;
            }
        }

        private void manageBlockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is slated for implementation in iteration 2", "Not Yet Implemented");
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is slated for implementation in iteration 3", "Not Yet Implemented");
        }

        private void BookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is slated for implementation in iteration 3", "Not Yet Implemented");
        }

        private void RunNewTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenNewTab();
        }

        private void RunQuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
