using Edura.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Edura.Repository.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory _urlHelperFactory)
        {
            urlHelperFactory = _urlHelperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            var result = new TagBuilder("div");

            for (int i = 1; i <= PageModel.TotalPages(); i++)
            {
                //sayfaya gore a tagi olusturacagiz.
                var tag = new TagBuilder("a"); 
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });
                tag.InnerHtml.Append(i.ToString());

                if (i == PageModel.CurrentPage)
                {
                    tag.AddCssClass("btn btn-success");
                }
                else
                {
                    tag.AddCssClass("btn btn-warning");
                }
                result.InnerHtml.AppendHtml(tag); // divin icine a etiketini ekle dedik.
            }
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}