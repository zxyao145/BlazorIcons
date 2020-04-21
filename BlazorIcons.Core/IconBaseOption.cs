using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using BlazorIcons.Extensions;
using Microsoft.AspNetCore.Components;

namespace BlazorIcons
{
    public class IconBaseOption : ComponentBase
    {
        #region handled by element class

        [Parameter]
        public string ClassName { get; set; }

        /// <summary>
        /// 是否旋转（loading效果）
        /// </summary>
        [Parameter]
        public bool IsSpin { get; set; }

        #endregion

        #region handled by element style
        [Parameter]
        public string Style { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [Parameter]
        public float? FontSize { get; set; } = null;

        /// <summary>
        /// 宽度
        /// </summary>
        [Parameter]
        public float? Width { get; set; } = null;

        /// <summary>
        /// 高度
        /// </summary>
        [Parameter]
        public float? Height { get; set; } = null;

        /// <summary>
        /// 字体颜色
        /// </summary>
        [Parameter]
        public Color? Color { get; set; } = null;

        /// <summary>
        /// 背景色
        /// </summary>
        [Parameter]
        public Color? BgColor { get; set; } = null;

        /// <summary>
        /// 旋转度数
        /// </summary>
        [Parameter]
        public float? Rotate { get; set; } = null;

        #endregion


        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object> AdditionalAttributes { get; set; }

        internal string GetClassName()
        {
            var classNameList = new List<string>();
            classNameList.AddIf(!string.IsNullOrWhiteSpace(ClassName), ClassName);
            classNameList.AddIf(IsSpin, "bi-spin");

            return string.Join(" ", classNameList);
        }

        internal string GetStyle()
        {
            var styleList = new List<string>();
            styleList.AddIf(
                !string.IsNullOrWhiteSpace(Style),
                Style
                );
            styleList.AddIf(FontSize != null, $"font-size:{FontSize}px");
            styleList.AddIf(Width != null, $"width:{Width}px");
            styleList.AddIf(Height != null, $"height:{Height}px");

            styleList.AddIf(Color != null,
                Color,
                (color) => $"color:{color.Value.ToCssString()}");
            styleList.AddIf(BgColor != null,
                BgColor,
                (color) => $"background-color:{color.Value.ToCssString()}");

            styleList.AddIf(Rotate != null, $"transform:rotate({Rotate}deg)");

            return string.Join(";", styleList);
        }
    }
}
