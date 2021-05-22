using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRenderersExample.customrenders;
using CustomRenderersExample.Droid.customrenders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]

namespace CustomRenderersExample.Droid.customrenders
{
   public class MyEntryRenderer : EntryRenderer
    {
      public  MyEntryRenderer(Context context):base(context) { }

        [Obsolete]
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null) {
                Control.Background = Forms.Context.GetDrawable(Resource.Drawable.RoundedEditText);
                Control.SetAllCaps(true);
            }
        }

    }
}