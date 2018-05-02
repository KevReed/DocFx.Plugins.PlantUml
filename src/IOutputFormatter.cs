using Microsoft.DocAsCode.MarkdownLite;

namespace DocFx.Plugins.PlantUml
{
    internal interface IOutputFormatter
    {
        StringBuffer FormatOutput(MarkdownCodeBlockToken token, byte[] output);
    }
}