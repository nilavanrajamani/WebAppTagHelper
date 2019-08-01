using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTagHelperPrj.TagHelpers
{
    public class ModelExpTagHelper : TagHelper
    {
        public ModelExpression HelperFor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var str = HelperFor == null ? "" : " Name: " + HelperFor.Name + " Model: " + HelperFor.Model;
            output.Content.SetContent(str);
        }
    }
}
