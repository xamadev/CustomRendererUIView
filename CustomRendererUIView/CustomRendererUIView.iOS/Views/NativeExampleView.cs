using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CustomRendererUIView.iOS.Views
{
    [DesignTimeVisible(true)]
    public partial class NativeExampleView : UIView
    {
        public NativeExampleView (IntPtr handle) : base (handle)
        {
        }

        public static NativeExampleView Create()
        {

            var arr = NSBundle.MainBundle.LoadNib("NativeExampleView", null, null);
            var v = Runtime.GetNSObject<NativeExampleView>(arr.ValueAt(0));

            return v;
        }

        public override void AwakeFromNib()
        {
            MyLabel.Text = "hello from the SomeView class";
        }
    }
}