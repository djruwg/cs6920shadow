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
            this.RenderingWebView.Size = new System.Drawing.Size(1351, 956);
            this.RenderingWebView.TabIndex = 0;
            this.RenderingWebView.ZoomFactor = 1D;
            // 
            // RenderingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RenderingWebView);
            this.Name = "RenderingUserControl";
            this.Size = new System.Drawing.Size(1351, 956);
            this.Load += new System.EventHandler(this.RenderingUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RenderingWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 RenderingWebView;
    }
}
