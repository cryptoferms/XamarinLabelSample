using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Platform.Android;
using XamarinLabelSample.Droid;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(Xamarin.Forms.Label), typeof(LabelRendererStyle))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace XamarinLabelSample.Droid
{
    [Obsolete]
    public class LabelRendererStyle : LabelRenderer
    { 
        protected void setFontSizeAgain()
        {
            var nativeControl = (TextView)Control;
            var xamarinControl = Element;
            if (nativeControl != null && xamarinControl != null)
                nativeControl.SetTextSize(Android.Util.ComplexUnitType.Dip, xamarinControl.Font.ToScaledPixel());
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
        {
            base.OnElementChanged(e);
            setFontSizeAgain();
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            setFontSizeAgain();
        }
    }
}