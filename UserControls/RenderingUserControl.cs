using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BBB.UserControls
{
    public interface RenderingUserControlInterface
    {
        void RenderingUserControlEvent();
    }

    public partial class RenderingUserControl : UserControl
    {
        RenderingUserControlInterface listener;

        /// <summary>
        /// Constructor
        /// </summary>
        public RenderingUserControl(RenderingUserControlInterface listener)
        {
            InitializeComponent();
            InitializeWebView2();
            this.listener = listener;
        }

        /// <summary>
        /// Initializes a WebView2 instance
        /// </summary>
        private async void InitializeWebView2()
        {
            await RenderingWebView.EnsureCoreWebView2Async();
        }

        private void RenderingUserControl_Load(object sender, System.EventArgs e)
        {
            //RenderingWebView.EnsureCoreWebView2Async();
        }

        /// <summary>
        /// Navigates to the given URL
        /// </summary>
        /// <param name="url"></param>
        public void GoToURL(string url)
        {
            RenderingWebView.Source = new Uri(url);
        }

        /// <summary>
        /// Determines if you can navigate backward in the browser history
        /// </summary>
        /// <returns>true if backward navigation is allowed</returns>
        public bool CanGoBack()
        {
            return RenderingWebView.CanGoBack;
        }

        /// <summary>
        /// Navigates backward in the browser history
        /// </summary>
        public void GoBack()
        {
            if (RenderingWebView.CanGoBack)
            {
                RenderingWebView.GoBack();
            }
        }

        /// <summary>
        /// Determines if you can navigate forward in the browser history
        /// </summary>
        /// <returns>true if forward navigation is allowed</returns>
        public bool CanGoForward()
        {
            return RenderingWebView.CanGoForward;
        }

        /// <summary>
        /// Navigates forward in the browser history
        /// </summary>
        public void GoForward()
        {
            if (RenderingWebView.CanGoForward)
            {
                RenderingWebView.GoForward();
            }
        }

        /// <summary>
        /// Reloads the current page
        /// </summary>
        public void Reload()
        {
            RenderingWebView.Reload();
        }

        public string GetUrl()
        {
            return RenderingWebView.Source.ToString();
        }

        /// <summary>
        /// Called when WebView2 completes initialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenderingWebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            Debug.WriteLine("initialization completed");
        }

        /// <summary>
        /// Called when WebView2 starts navigating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenderingWebView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            Debug.WriteLine("navigation starting");
        }

        /// <summary>
        /// Called when the WebView2 source URL changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenderingWebView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            Debug.WriteLine("source changed");
            listener.RenderingUserControlEvent();

        }

        /// <summary>
        /// Called when WebView2 content begins loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenderingWebView_ContentLoading(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
        {
            Debug.WriteLine("content loading");
        }

        /// <summary>
        /// Called when WebView2 navigation completes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenderingWebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Debug.WriteLine("navigation completed");
        }
    }
}
