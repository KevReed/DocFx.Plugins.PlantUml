using Microsoft.DocAsCode.MarkdownLite;

using static System.Text.Encoding;

namespace DocFx.Plugins.PlantUml.OutputFormatters
{
    internal class AsciiUnicodeOutputFormatter : IOutputFormatter
    {
        private Options options;

        public AsciiUnicodeOutputFormatter(Options options)
        {
            this.options = options;
        }

        public StringBuffer FormatOutput(MarkdownCodeBlockToken token, byte[] output)
        {
            string ascii = UTF8.GetString(output);

            return $"<div class=\"{options.LangPrefix}plantUml\" \\><pre>{ascii}</pre></div>";
        }
    }
}