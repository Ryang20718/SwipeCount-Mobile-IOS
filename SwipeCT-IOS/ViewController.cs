using System;
using Foundation;
using UIKit;
using WebKit;

namespace SwipeCTIOS
{
    public partial class ViewController : UIViewController
    {
        WKWebView webView;
        NSUrl url = new NSUrl("http://ryanyang.me/SwipeCount/");
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            webView = new WKWebView(View.Frame, new WKWebViewConfiguration());
            View.AddSubview(webView);
            webView.LoadRequest(new NSUrlRequest(url));


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
