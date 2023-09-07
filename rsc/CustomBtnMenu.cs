using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CocoaLib.rsc
{
    class CustomBtnMenu : Button
    {
        public CornerRadius ButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(ButtonCornerRadiusProperty); }
            set { SetValue(ButtonCornerRadiusProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register("ButtonCornerRadius", typeof(CornerRadius), typeof(CustomBtnMenu)/*, new PropertyMetadata(0)*/);


        public Brush ColorPressed
        {
            get { return (Brush)GetValue(ColorPressedProperty); }
            set { SetValue(ColorPressedProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ColorPressed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorPressedProperty =
            DependencyProperty.Register("ColorPressed", typeof(Brush), typeof(CustomBtnMenu)/*, new PropertyMetadata(0)*/);




        public Brush ColorHover
        {
            get { return (Brush)GetValue(ColorHoverProperty); }
            set { SetValue(ColorHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ColorHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorHoverProperty =
            DependencyProperty.Register("ColorHover", typeof(Brush), typeof(CustomBtnMenu)/*, new PropertyMetadata(0)*/);




    }
}
