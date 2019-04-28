using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Vk
{
    public class MyButton : Button
    {
        public new static readonly BindableProperty PaddingProperty = BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(Button), default(Thickness));
        public new Thickness Padding
        {
            get => (Thickness)this.GetValue(PaddingProperty);
            set => this.SetValue(PaddingProperty, value);
        }

    }
}
