using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Configuration;

namespace LucasTechnologyServices.Module.Core.Extensions.TagHelpers
{
    [HtmlTargetElement(Attributes = AppendVersionAttributeName)]
    public class AppendVersionTagHelper : TagHelper
    {
        private const AppendVersionAttributeName = "lts-append-version";
        private readonly IConfiguration _config;

        public AppendVersionTagHelper(IConfiguration config)
        {
            _config = config;
        }

        [HtmlAttributeName(AppendVersionAttributeName)]
        public bool Appendversion { get; set; }

        public override int Order => int.MinValue;

        public string AppendVersionAttributeName { get; private set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll(AppendVersionAttributeName);
            if (!Appendversion)
            {
                return;
            }

            if (output.Attributes.ContainsName("href"))
            {
                var href = output.Attributes["href"].Value.ToString();
                output.Attributes
            }

            if (output.Attributes.ContainsName("src"))
            {
                var src = output.Attributes;
            }
        }
    }
}
