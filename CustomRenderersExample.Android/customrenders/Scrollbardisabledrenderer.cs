using CustomRenderersExample.customrenders;
using CustomRenderersExample.Droid.customrenders;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyScrollView), typeof(Scrollbardisabledrenderer))]

namespace CustomRenderersExample.Droid.customrenders
{
    [System.Obsolete]
    public class Scrollbardisabledrenderer : ScrollViewRenderer
    {

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;

        }

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            this.HorizontalScrollBarEnabled = false;
            this.VerticalScrollBarEnabled = false;

        }
    }
}