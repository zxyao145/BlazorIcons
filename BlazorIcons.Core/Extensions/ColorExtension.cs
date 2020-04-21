using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlazorIcons.Extensions
{
    public static class ColorExtension
    {
        public static string ToCssString(this Color color)
        {
            return color.A == 255
                ? $"rgb({color.R},{color.G},{color.B})"
                : $"rgba({color.R},{color.G},{color.B},{color.A / 255.0:F2})";
        }
    }
}
