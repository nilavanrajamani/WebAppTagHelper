using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTagHelperPrj.TagHelpers
{
    [HtmlTargetElement("tab-item", ParentTag = "tab")]
    public class TabItemTagHelper : TagHelper
    {
        public string Title { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string activePage = context.Items["ActivePage"] as string;
            if (activePage == Title)
            {
                output.Attributes.Add("class", "active");
            }
            output.TagName = "li";
            var str = string.Format("<a href='#'>{0}</a>", Title);
            output.Content.SetHtmlContent(str);
        }
    }
}
