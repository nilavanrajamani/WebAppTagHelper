﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTagHelperPrj.TagHelpers
{
    [HtmlTargetElement("auto-price", Attributes = "variety")]
    public class AutoPriceTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        public string Make { get; set; }
        [HtmlAttributeName("model-name")]
        public string Model { get; set; }
        public string Variety { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}
