using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UIKit;
using Vk;
using Vk.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(MyButton), typeof(MyButtonRenderer))]
namespace Vk.Droid
{
    [Obsolete]
    class MyButtonRenderer : ButtonRenderer
    {
       
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (this.Control == null || this.Element == null)
            {
                return;
            }

            this.DoChange();

            // Control?.SetPadding(0, 0, 0, 0);
            // Control.CompoundDrawablePadding = 0;
            //// Gravity = GravityFlags.Left | GravityFlags.CenterVertical
            // Control.Gravity = GravityFlags.Left | GravityFlags.CenterVertical;
        }
        private void DoChange()
        {
            // Padding
            this.Control.SetPadding(
                (int)((MyButton)this.Element).Padding.Left,
                (int)((MyButton)this.Element).Padding.Top,
                (int)((MyButton)this.Element).Padding.Right,
                (int)((MyButton)this.Element).Padding.Bottom);
        }
    }
}