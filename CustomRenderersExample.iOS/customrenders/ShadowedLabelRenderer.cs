using CoreGraphics;
using CustomRenderersExample.customrenders;
using CustomRenderersExample.iOS.customrenders;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ShadowedLabel), typeof(ShadowedLabelRenderer))]

namespace CustomRenderersExample.iOS.customrenders
{

    class ShadowedLabelRenderer : LabelRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Control.Layer.ShadowColor = UIColor.DarkGray.CGColor;
            Control.Layer.ShadowOpacity = 1.0f;
            Control.Layer.ShadowRadius = 2f;
            Control.Layer.ShadowOffset = new CGSize(4, 4);
            Control.Layer.MasksToBounds = false;
        }
    }
}