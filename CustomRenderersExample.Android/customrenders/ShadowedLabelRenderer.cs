using Android.Content;
using CustomRenderersExample.customrenders;
using CustomRenderersExample.Droid.customrenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ShadowedLabel), typeof(ShadowedLabelRenderer))]

namespace CustomRenderersExample.Droid.customrenders
{
    public class ShadowedLabelRenderer : LabelRenderer
    {
        public ShadowedLabelRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Control.SetShadowLayer(10, 5, 5, Android.Graphics.Color.DarkGray);

        }
    }
}