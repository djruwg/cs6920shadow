using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace BBB.UserControls
{
    public partial class RenderingUserControl : UserControl
    {
        public RenderingUserControl()
        {
            InitializeComponent();
            InitializeWebView2();
        }

        private async void InitializeWebView2()
        {
            await RenderingWebView.EnsureCoreWebView2Async();
        }

        private void RenderingUserControl_Load(object sender, System.EventArgs e)
        {
            //RenderingWebView.EnsureCoreWebView2Async();
        }

        public void GoToURL(string url)
        {
            RenderingWebView.Source = new Uri(url);
        }

        public bool CanGoBack()
        {
            return RenderingWebView.CanGoBack;
        }

        public void GoBack()
        {
            if (RenderingWebView.CanGoBack)
            {
                RenderingWebView.GoBack();
            }
        }

        public bool CanGoForward()
        {
            return RenderingWebView.CanGoForward;
        }

        public void GoForward()
        {
            if (RenderingWebView.CanGoForward)
            {
                RenderingWebView.GoForward();
            }
        }

        public void Reload()
        {
            RenderingWebView.Reload();
        }

        private void RenderingWebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            Debug.WriteLine("initialization completed");
        }

        private void RenderingWebView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            Debug.WriteLine("navigation starting");
        }

        private void RenderingWebView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            Debug.WriteLine("source changed");

        }

        private void RenderingWebView_ContentLoading(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
        {
            Debug.WriteLine("content loading");
        }

        private void RenderingWebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Debug.WriteLine("navigation completed");
        }
    }
}
