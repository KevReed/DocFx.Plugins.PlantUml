using System.Collections.Generic;
using PlantUml.Net;

namespace DocFx.Plugins.PlantUml
{
    internal class DocFxPlantUmlSettings : PlantUmlSettings
    {
        public DocFxPlantUmlSettings(IReadOnlyDictionary<string, object> parameters)
        {
            JavaPath = parameters.GetValueOrDefault("plantUml.javaPath", JavaPath);
            LocalGraphvizDotPath = parameters.GetValueOrDefault("plantUml.localGraphvizDotPath", LocalGraphvizDotPath);
            LocalPlantUmlPath = parameters.GetValueOrDefault("plantUml.localPlantUmlPath", LocalPlantUmlPath);
            OutputFormat = parameters.GetEnumOrDefault("plantUml.outputFormat", OutputFormat.Svg);
            RemoteUrl = parameters.GetValueOrDefault("plantUml.remoteUrl", RemoteUrl);
            RenderingMode = parameters.GetEnumOrDefault("plantUml.renderingMode", RenderingMode);
        }
    }
}