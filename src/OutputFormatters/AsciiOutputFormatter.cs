using Microsoft.DocAsCode.MarkdownLite;

using static System.Text.Encoding;

namespace DocFx.Plugins.PlantUml.OutputFormatters
{
    internal class AsciiOutputFormatter : IOutputFormatter
    {
        private Options options;

        public AsciiOutputFormatter(Options options)
        {
            this.options = options;
        }

        public StringBuffer FormatOutput(MarkdownCodeBlockToken token, byte[] output)
        {
            string ascii = ASCII.GetString(output);

            return $"<div class=\"{options.LangPrefix}plantUml\" \\><pre>{ascii}</pre></div>";
        }
    }
}