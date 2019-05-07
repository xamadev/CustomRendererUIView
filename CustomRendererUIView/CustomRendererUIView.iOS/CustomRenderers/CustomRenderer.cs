using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using CoreGraphics;
using CustomRendererUIView.CustomControls;
using CustomRendererUIView.iOS;
using CustomRendererUIView.iOS.CustomRenderers;
using CustomRendererUIView.iOS.Views;
using Foundation;

using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomRenderer))]
namespace CustomRendererUIView.iOS.CustomRenderers
{
    public class CustomRenderer : ViewRenderer<CustomView, NativeExampleView>
    {

        NativeExampleView _nativeExampleView;

        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                //_regionenUIView = new RegionenView();

                _nativeExampleView = NativeExampleView.Create();

                SetNativeControl(_nativeExampleView);
            }
            if (e.OldElement != null)
            {
                // Unsubscribe
                //uiButton.Tapped -= OnCameraPreviewTapped;
            }
            if (e.NewElement != null)
            {
                // Subscribe
                //uiButton.Tapped += OnCameraPreviewTapped;
            }
        }
    }
}