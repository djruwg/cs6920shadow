namespace BBB.UserControls
{
    partial class RenderingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RenderingWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.RenderingWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // RenderingWebView
            // 
            this.RenderingWebView.AllowExternalDrop = true;
            this.RenderingWebView.CreationProperties = null;
            this.RenderingWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.RenderingWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenderingWebView.Location = new System.Drawing.Point(0, 0);
            this.RenderingWebView.Name = "RenderingWebView";
            this.RenderingWebView.Size = new System.Drawing.Size(1500, 1111);
            this.RenderingWebView.TabIndex = 0;
            this.RenderingWebView.ZoomFactor = 1D;
            this.RenderingWebView.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.RenderingWebView_CoreWebView2InitializationCompleted);
            this.RenderingWebView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.RenderingWebView_NavigationStarting);
            this.RenderingWebView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.RenderingWebView_NavigationCompleted);
            this.RenderingWebView.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.RenderingWebView_SourceChanged);
            this.RenderingWebView.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.RenderingWebView_ContentLoading);
            // 
            // RenderingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.RenderingWebView);
            this.Name = "RenderingUserControl";
            this.Size = new System.Drawing.Size(1500, 1111);
            this.Load += new System.EventHandler(this.RenderingUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RenderingWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 RenderingWebView;
    }
}
