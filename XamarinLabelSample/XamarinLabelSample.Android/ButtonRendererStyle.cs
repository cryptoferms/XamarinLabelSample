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
using Xamarin.Forms.Platform.Android;
using XamarinLabelSample.Droid;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(ButtonRendererStyle))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace XamarinLabelSample.Droid
{
    [Obsolete]
    public class ButtonRendererStyle : ButtonRenderer
    {
        protected void SetFontSizeAgain()
        {
            var abtn = (Android.Widget.Button)Control;
            var xfbtn = Element;
            if (abtn != null && xfbtn != null)
                abtn.SetTextSize(Android.Util.ComplexUnitType.Dip, xfbtn.Font.ToScaledPixel());
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            SetFontSizeAgain();
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == Xamarin.Forms.Button.FontProperty.PropertyName)
                SetFontSizeAgain();
        }
    }
}