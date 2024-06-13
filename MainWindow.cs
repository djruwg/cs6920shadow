using BBB.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BBB
{
    public partial class MainWindow : Form
    {
        private const int TAB_LEADING_SPACE = 8;
        private const int TAB_TRAILING_SPACE = 16;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Use this to invoke test code
        private void RunTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.AdjustTabSizes();
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
            RenderingUserControl browser = new RenderingUserControl();
            tabPage.Controls.Add(browser);
            // browserList.Add(browser);
            MainWindowTabControl.Controls.Add(tabPage);
            this.AdjustTabSizes();
            MainWindowTabControl.SelectTab(tabPage);
            browser.GoToURL("https://www.google.com");
        }
    }
}
