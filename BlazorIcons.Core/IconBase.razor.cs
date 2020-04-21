using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace BlazorIcons
{
    public sealed partial class IconBase
    {
        [CascadingParameter]
        public IconBaseOption IconOption { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string IconName { get; set; }
    }
}
