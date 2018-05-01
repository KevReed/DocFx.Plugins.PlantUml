using Microsoft.DocAsCode.Dfm;
using PlantUml.Net;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;

namespace DocFx.Plugins.PlantUml
{
    [Export(typeof(IDfmCustomizedRendererPartProvider))]
    public class PlantUmlPartProvider : IDfmCustomizedRendererPartProvider
    {
        /// <summary>
        /// parameters are passed in docfx.json under plantumlRenderingMode.
        /// <para>accepted parameters:</para>
        /// <para>plantUml.renderingMode, "local" or "remote" (default to "remote")</para>
        /// <para>plantUml.url, defaults to "http://www.plantuml.com/plantuml/"</para>
        /// <para>plantUml.outputFormat, "svg", "png", "ascii" </para>
        /// <para>plantUml.javaPath</para>
        /// </summary>
        /// <example>
        /// <![CDATA[
        /// "markdownEngineProperties": {
        ///   "plantuml.RenderingMode" : "local"
        /// }
        /// ]]>
        /// </example>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<IDfmCustomizedRendererPart> CreateParts(IReadOnlyDictionary<string, object> parameters)
        {
            PlantUmlSettings settings = new DocFxPlantUmlSettings(parameters);
            yield return new PlantUmlMarkdownRenderer(settings);
        }
    }
}
