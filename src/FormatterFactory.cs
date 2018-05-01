using System;
using DocFx.Plugins.PlantUml.OutputFormatters;
using PlantUml.Net;

namespace DocFx.Plugins.PlantUml
{
    internal class FormatterFactory
    {
        internal IOutputFormatter CreateOutputFormatter(OutputFormat outputFormat)
        {
            switch (outputFormat)
            {
                case OutputFormat.Svg:

                    return new SvgOutputFormatter();

                case OutputFormat.Png:
                case OutputFormat.Eps:
                case OutputFormat.Pdf:
                case OutputFormat.Vdx:
                case OutputFormat.Xmi:
                case OutputFormat.Scxml:
                case OutputFormat.Html:
                case OutputFormat.Ascii:
                case OutputFormat.Ascii_Unicode:
                case OutputFormat.LaTeX:
                default:

                    throw new NotSupportedException($"output format {outputFormat} is not currently supported");
            }
        }
    }
}