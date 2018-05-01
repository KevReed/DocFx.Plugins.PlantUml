using System;
using Microsoft.DocAsCode.Dfm;
using Microsoft.DocAsCode.MarkdownLite;
using PlantUml.Net;

namespace DocFx.Plugins.PlantUml
{
    public class PlantUmlMarkdownRenderer : DfmCustomizedRendererPartBase<IMarkdownRenderer, MarkdownCodeBlockToken, MarkdownBlockContext>
    {
        private const string LANGUAGE_TAG = "plantUml";

        private readonly PlantUmlSettings plantUmlSettings;
        private readonly RendererFactory rendererFactory;
        private readonly FormatterFactory formatterFactory;

        public override string Name => nameof(PlantUmlMarkdownRenderer);

        public PlantUmlMarkdownRenderer(PlantUmlSettings plantUmlSettings)
        {
            this.plantUmlSettings = plantUmlSettings;
            rendererFactory = new RendererFactory();
            formatterFactory = new FormatterFactory();
        }

        public override bool Match(IMarkdownRenderer renderer, MarkdownCodeBlockToken token, MarkdownBlockContext context)
        {
            return string.Equals(token.Lang, LANGUAGE_TAG, StringComparison.InvariantCultureIgnoreCase);
        }

        public override StringBuffer Render(IMarkdownRenderer renderer, MarkdownCodeBlockToken token, MarkdownBlockContext context)
        {
            IPlantUmlRenderer plantUmlRenderer = rendererFactory.CreateRenderer(plantUmlSettings);
            IOutputFormatter outputFormatter = formatterFactory.CreateOutputFormatter(plantUmlSettings.OutputFormat);

            string output = plantUmlRenderer.Render(token.Code, plantUmlSettings.OutputFormat);
            return outputFormatter.FormatOutput(renderer.Options.LangPrefix, output);
        }
    }
}
