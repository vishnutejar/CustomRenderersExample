using CustomRenderersExample.customrenders;
using CustomRenderersExample.iOS.customrenders;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyScrollView), typeof(Scrollbardisabledrenderer))]
namespace CustomRenderersExample.iOS.customrenders
{
    [System.Obsolete]
    public class Scrollbardisabledrenderer : ScrollViewRenderer
    {
     protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
                return;

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;
            e.NewElement.PropertyChanged += OnElementPropertyChanged;
        }

        private void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ShowsHorizontalScrollIndicator = false;
            ShowsVerticalScrollIndicator = false;
        }
    }
}
