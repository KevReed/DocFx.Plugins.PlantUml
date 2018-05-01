using Microsoft.DocAsCode.MarkdownLite;

namespace DocFx.Plugins.PlantUml.OutputFormatters
{
    internal class SvgOutputFormatter : IOutputFormatter
    {
        public StringBuffer FormatOutput(string langPrefix, string output)
        {
            return $"<div class=\"{langPrefix}plantUml\" \\> {output} </div>";
        }
    }
}