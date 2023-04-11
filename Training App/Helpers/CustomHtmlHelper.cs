using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Training_App.Helpers
{
    public static class CustomHtmlHelper
    {
        public static IHtmlString Img(this HtmlHelper htmlHelper, string src, string alt)
        {
            TagBuilder builder = new TagBuilder("img");
            builder.Attributes.Add("src", src);
            builder.Attributes.Add("alt", alt);
            return new MvcHtmlString(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}