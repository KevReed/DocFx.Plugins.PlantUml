using Microsoft.DocAsCode.MarkdownLite;

using static System.Text.Encoding;

namespace DocFx.Plugins.PlantUml.OutputFormatters
{
    internal class SvgOutputFormatter : IOutputFormatter
    {
        private Options options;

        public SvgOutputFormatter(Options options)
        {
            this.options = options;
        }

        public StringBuffer FormatOutput(MarkdownCodeBlockToken token, byte[] output)
        {
            string svg = UTF8.GetString(output);

            return $"<div class=\"{options.LangPrefix}plantUml\" \\> {svg} </div>";
        }
    }
}