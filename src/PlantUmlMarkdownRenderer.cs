using System;
using Microsoft.DocAsCode.Dfm;
using Microsoft.DocAsCode.MarkdownLite;
using PlantUml.Net;

namespace DocFx.Plugins.PlantUml
{
    public class PlantUmlMarkdownRenderer : DfmCustomizedRendererPartBase<IMarkdownRenderer, MarkdownCodeBlockToken, MarkdownBlockContext>
    {
        private const string LANGUAGE_TAG = "plantUml";

        private readonly DocFxPlantUmlSettings settings;
        private readonly RendererFactory rendererFactory;
        private readonly FormatterFactory formatterFactory;

        public override string Name => nameof(PlantUmlMarkdownRenderer);

        public PlantUmlMarkdownRenderer(DocFxPlantUmlSettings settings)
        {
            this.settings = settings;
            rendererFactory = new RendererFactory();
            formatterFactory = new FormatterFactory(settings);
        }

        public override bool Match(IMarkdownRenderer renderer, MarkdownCodeBlockToken token, MarkdownBlockContext context)
        {
            return string.Equals(token.Lang, LANGUAGE_TAG, StringComparison.InvariantCultureIgnoreCase);
        }

        public override StringBuffer Render(IMarkdownRenderer markdownRenderer, MarkdownCodeBlockToken token, MarkdownBlockContext context)
        {
            IPlantUmlRenderer plantUmlRenderer = rendererFactory.CreateRenderer(settings);
            IOutputFormatter outputFormatter = formatterFactory.CreateOutputFormatter(markdownRenderer.Options);

            byte[] output = plantUmlRenderer.Render(token.Code, settings.OutputFormat);
            return outputFormatter.FormatOutput(token, output);
        }
    }
}
