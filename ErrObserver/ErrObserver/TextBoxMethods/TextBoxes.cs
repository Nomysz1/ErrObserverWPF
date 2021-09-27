using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace ErrObserver.TextBoxMethods
{
    class TextBoxes
    {
        public static void setUpCorrectColor(ref bool result, TextBox tb)
        {
            if (result == false)
                tb.Foreground = Brushes.Red;
            else
                tb.Foreground = Brushes.Blue;
        }
    }
}
