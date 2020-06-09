using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinLabelSample;
using XamarinLabelSample.Droid;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(EntryStyle), typeof(EntryStyleRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace XamarinLabelSample.Droid
{
    [Obsolete]
    public class EntryStyleRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Rgb(237, 237, 237));
                gd.SetCornerRadius(15);
                Control.SetBackgroundDrawable(gd);
                Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.Blue));
            }
        }
    }
}