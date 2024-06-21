using System.Diagnostics;

namespace BBB.UserControls
{
    /// <summary>
    /// Interface for interacting with this control.
    /// </summary>
    public interface RenderingUserControlInterface
    {
        void RenderingUserControlEvent(object sender, EventArgs e);
    }

    /// <summary>
    /// A user control for rendering web pages.
    /// </summary>
    public partial class RenderingUserControl : UserControl
    {
        private RenderingUserControlInterface _listener;
        private string _pageTitle;

        /// <summary>
        /// Constructor
        /// </summary>
        public RenderingUserControl(RenderingUserControlInterface listener)
        {
            InitializeComponent();
            InitializeWebView2();
            this._pageTitle = string.Empty;
            this._listener = listener;
        }

        /// <summary>
        /// Initializes a WebView2 instance
        /// </summary>
        private async void InitializeWebView2()
        {
            await RenderingWebView.EnsureCoreWebView2Async();
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

        /// <summary>
        /// Get the current URL
        /// </summary>
        /// <returns>A URL string</returns>
        public string GetUrl()
        {
            return RenderingWebView.Source.ToString();
        }

        /// <summary>
        /// Get the current page title
        /// </summary>
        /// <returns>A page title string</returns>
        public string GetPageTitle()
        {
            return this._pageTitle;
        }

        /// <summary>
        /// Called when WebView2 completes initialization
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The event</param>
        private void RenderingWebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            Debug.WriteLine("initialization completed");
        }

        /// <summary>
        /// Called when WebView2 starts navigating
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The event</param>
        private void RenderingWebView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            Debug.WriteLine("navigation starting");
        }

        /// <summary>
        /// Called when the WebView2 source URL changes
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The event</param>
        private void RenderingWebView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            if (RenderingWebView.CoreWebView2 != null)
            {
                this._pageTitle = RenderingWebView.Source.ToString();
            }

            this._listener.RenderingUserControlEvent(sender, e);

        }

        /// <summary>
        /// Called when WebView2 content begins loading
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The event</param>
        private void RenderingWebView_ContentLoading(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
        {
            Debug.WriteLine("content loading");
        }

        /// <summary>
        /// Called when WebView2 navigation completes
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The event</param>
        private void RenderingWebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (RenderingWebView.CoreWebView2 != null)
            {
                this._pageTitle = RenderingWebView.CoreWebView2.DocumentTitle;
            }

            this._listener.RenderingUserControlEvent(sender, e);
        }

        /// <summary>
        /// Runs the provided Javascript
        /// </summary>
        /// <param name="script">A string of Javascript</param>
        /// <returns>An async task</returns>
        public async Task RunScriptAsync(string script)
        {
            await RenderingWebView.CoreWebView2.ExecuteScriptAsync(script);
        }

        /// <summary>
        /// Opens the print dialog
        /// </summary>
        /// <returns></returns>
        public async Task OpenPrintDialog()
        {
            await RenderingWebView.CoreWebView2.ExecuteScriptAsync("window.print();");
        }

        /// <summary>
        /// Opens the developer tools
        /// </summary>
        public void OpenDeveloperTools()
        {
            RenderingWebView.CoreWebView2.OpenDevToolsWindow();
        }

        /// <summary>
        /// Opens the task manager
        /// </summary>
        public void OpenTaskManager()
        {
            RenderingWebView.CoreWebView2.OpenTaskManagerWindow();
        }
    }
}
