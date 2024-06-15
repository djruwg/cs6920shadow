﻿using BBB.Helpers;
using BBB.UserControls;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BBB
{
    public partial class MainWindow : Form, RenderingUserControlInterface
    {
        private const int TAB_LEADING_SPACE = 8;
        private const int TAB_TRAILING_SPACE = 16;

        private static readonly Regex urlRegex = new Regex(@"^(https?|ftp)?(:\/\/)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}([\/\w .-]*)*\/?$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Perform initial setup once this component has loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Image image = MainWindowReloadButton.BackgroundImage;
            Bitmap objBitmap = new Bitmap(image, new Size(14, 14));
            MainWindowReloadButton.BackgroundImage = objBitmap;

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
            RenderingUserControl renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.OpenPrintDialog();
            }
        }

        /// <summary>
        /// Launches the developer tools window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunDeveloperToolsMenuItem_Click(object sender, EventArgs e)
        {
            RenderingUserControl renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.OpenDeveloperTools();
            }
        }

        private void RunTaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderingUserControl renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.OpenTaskManager();
            }
        }

        /// <summary>
        /// Returns the rendering user control of the currently selected tab
        /// </summary>
        /// <returns></returns>
        private RenderingUserControl GetRenderingUserControl()
        {
            RenderingUserControl renderingControl = null;

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
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - TAB_TRAILING_SPACE, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.MainWindowTabControl.TabPages[e.Index].Text,
                e.Font, Brushes.Black, e.Bounds.Left + TAB_LEADING_SPACE, e.Bounds.Top + 4);
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
            browser.GoToURL("https://www.google.com");
        }

        /// <summary>
        /// Listen for rendering user control events.
        /// </summary>
        public void RenderingUserControlEvent(object sender, EventArgs e)
        {
            RenderingUserControl renderingControl = GetRenderingUserControl();

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
            RenderingUserControl renderingControl = GetRenderingUserControl();

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
            RenderingUserControl renderingControl = GetRenderingUserControl();

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
            RenderingUserControl renderingControl = GetRenderingUserControl();

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
            RenderingUserControl renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.Reload();
            }
        }

        private void restWorkSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
