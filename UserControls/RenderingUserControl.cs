using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace BBB.UserControls
{
    public partial class RenderingUserControl : UserControl
    {
        public RenderingUserControl()
        {
            InitializeComponent();
        }

        private void RenderingUserControl_Load(object sender, System.EventArgs e)
        {
            RenderingWebView.EnsureCoreWebView2Async();
        }

        public void GoToURL(string url)
        {
            RenderingWebView.Source = new Uri(url);
        }
    }
}
