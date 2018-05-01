using Microsoft.DocAsCode.MarkdownLite;

namespace DocFx.Plugins.PlantUml
{
    internal interface IOutputFormatter
    {
        StringBuffer FormatOutput(string langPrefix, string output);
    }
}