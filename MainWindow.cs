using BBB.UserControls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BBB
{
    public partial class MainWindow : Form, RenderingUserControlInterface
    {
        private const int TAB_LEADING_SPACE = 8;
        private const int TAB_TRAILING_SPACE = 16;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.AdjustTabSizes();

            this.OpenNewTab();
        }

        // Use this to invoke test code
        private void RunTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GoToURL("https://www.kennesaw.edu");
            // MainWindowTabControl.TabPages[MainWindowTabControl.SelectedIndex].Text = "Kennesaw";
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

        private void MainWindowTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - TAB_TRAILING_SPACE, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.MainWindowTabControl.TabPages[e.Index].Text, 
                e.Font, Brushes.Black, e.Bounds.Left + TAB_LEADING_SPACE, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

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

        private void MainWindowNewTabButton_Click(object sender, EventArgs e)
        {
            this.OpenNewTab();
        }

        private void OpenNewTab()
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "New Tab";
            RenderingUserControl browser = new RenderingUserControl(this);
            tabPage.Controls.Add(browser);
            tabPage.AutoSize = true;
            MainWindowTabControl.Controls.Add(tabPage);
            this.AdjustTabSizes();
            MainWindowTabControl.SelectTab(tabPage);
            browser.GoToURL("https://www.google.com");
        }

        public void RenderingUserControlEvent()
        {
            RenderingUserControl renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                MainWindowBackButton.Enabled = renderingControl.CanGoBack();
                MainWindowForwardButton.Enabled = renderingControl.CanGoForward();
                MainWindowURLBar.Text = renderingControl.GetUrl();
            }
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
                if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
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

        private void MainWindowBackButton_Click(object sender, EventArgs e)
        {
            RenderingUserControl renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.GoBack();
            }
        }

        private void MainWindowForwardButton_Click(object sender, EventArgs e)
        {
            RenderingUserControl renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.GoForward();
            }
        }

        private void MainWindowReloadButton_Click(object sender, EventArgs e)
        {
            RenderingUserControl renderingControl = GetRenderingUserControl();

            if (renderingControl != null)
            {
                renderingControl.Reload();
            }
        }
    }
}
