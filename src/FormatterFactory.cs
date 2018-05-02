using System;
using DocFx.Plugins.PlantUml.OutputFormatters;
using Microsoft.DocAsCode.MarkdownLite;
using PlantUml.Net;

namespace DocFx.Plugins.PlantUml
{
    internal class FormatterFactory
    {
        private DocFxPlantUmlSettings settings;

        private OutputFormat OutputFormat => settings.OutputFormat;

        public FormatterFactory(DocFxPlantUmlSettings settings)
        {
            this.settings = settings;
        }

        internal IOutputFormatter CreateOutputFormatter(Options options)
        {
            switch (OutputFormat)
            {
                case OutputFormat.Svg:

                    return new SvgOutputFormatter(options);

                case OutputFormat.Ascii:

                    return new AsciiOutputFormatter(options);

                case OutputFormat.Ascii_Unicode:

                    return new AsciiUnicodeOutputFormatter(options);

                case OutputFormat.Png:
                case OutputFormat.Eps:
                case OutputFormat.Pdf:
                case OutputFormat.Vdx:
                case OutputFormat.Xmi:
                case OutputFormat.Scxml:
                case OutputFormat.Html:
                case OutputFormat.LaTeX:
                default:

                    throw new NotSupportedException($"output format {OutputFormat} is not currently supported");
            }
        }
    }
}