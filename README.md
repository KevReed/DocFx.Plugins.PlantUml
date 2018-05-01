# DocFx.PlantUml

DocFx.PlantUml is a template for DocFx to allow DFM (DocFx MarkDown) documents to render diagrams using PlantUml

## Installation Instructions

### Install via NuGet Package Manager

The nuget package should be installed to the project directory

```command
nuget install DocFx.PlantUml -OutputDirectory .
```

### add to docfx.json

Now you need to tell DocFx where to find the new template

assuming you extracted the package to the project directory:

in docfx.json:

```json
...
    "template": [
      "default",
      "DocFx.PlantUml.1.0.0\\content"
    ]
...
```

## Usage

To render a PlantUml diagram add a code block to you markup:

```markdown
'``plantUml

Bob->Alice : hello

'``
```

should render:

<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" contentScriptType="application/ecmascript" contentStyleType="text/css" height="127px" preserveAspectRatio="none" style="width:121px;height:127px;" version="1.1" viewBox="0 0 121 127" width="121px" zoomAndPan="magnify"><defs><filter height="300%" id="f1ovyoxgkqkxtz" width="300%" x="-1" y="-1"><feGaussianBlur result="blurOut" stdDeviation="2.0"/><feColorMatrix in="blurOut" result="blurOut2" type="matrix" values="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 .4 0"/><feOffset dx="4.0" dy="4.0" in="blurOut2" result="blurOut3"/><feBlend in="SourceGraphic" in2="blurOut3" mode="normal"/></filter></defs><g><line style="stroke: #A80036; stroke-width: 1.0; stroke-dasharray: 5.0,5.0;" x1="31" x2="31" y1="38.2969" y2="87.4297"/><line style="stroke: #A80036; stroke-width: 1.0; stroke-dasharray: 5.0,5.0;" x1="89" x2="89" y1="38.2969" y2="87.4297"/><rect fill="#FEFECE" filter="url(#f1ovyoxgkqkxtz)" height="30.2969" style="stroke: #A80036; stroke-width: 1.5;" width="42" x="8" y="3"/><text fill="#000000" font-family="sans-serif" font-size="14" lengthAdjust="spacingAndGlyphs" textLength="28" x="15" y="22.9951">Bob</text><rect fill="#FEFECE" filter="url(#f1ovyoxgkqkxtz)" height="30.2969" style="stroke: #A80036; stroke-width: 1.5;" width="42" x="8" y="86.4297"/><text fill="#000000" font-family="sans-serif" font-size="14" lengthAdjust="spacingAndGlyphs" textLength="28" x="15" y="106.4248">Bob</text><rect fill="#FEFECE" filter="url(#f1ovyoxgkqkxtz)" height="30.2969" style="stroke: #A80036; stroke-width: 1.5;" width="46" x="64" y="3"/><text fill="#000000" font-family="sans-serif" font-size="14" lengthAdjust="spacingAndGlyphs" textLength="32" x="71" y="22.9951">Alice</text><rect fill="#FEFECE" filter="url(#f1ovyoxgkqkxtz)" height="30.2969" style="stroke: #A80036; stroke-width: 1.5;" width="46" x="64" y="86.4297"/><text fill="#000000" font-family="sans-serif" font-size="14" lengthAdjust="spacingAndGlyphs" textLength="32" x="71" y="106.4248">Alice</text><polygon fill="#A80036" points="77,65.4297,87,69.4297,77,73.4297,81,69.4297" style="stroke: #A80036; stroke-width: 1.0;"/><line style="stroke: #A80036; stroke-width: 1.0;" x1="31" x2="83" y1="69.4297" y2="69.4297"/><text fill="#000000" font-family="sans-serif" font-size="13" lengthAdjust="spacingAndGlyphs" textLength="30" x="38" y="64.3638">hello</text>

### Diagram syntax

* [Sequence diagram](http://plantuml.com/sequence-diagram)
* [Usecase diagram](http://plantuml.com/use-case-diagram)
* [Class diagram](http://plantuml.com/activity-diagram-beta)
* [Activity diagram](http://plantuml.com/activity-diagram-beta)
* [Component diagram](http://plantuml.com/component-diagram)
* [State diagram](http://plantuml.com/state-diagram)
* [Object diagram](http://plantuml.com/object-diagram)
* [Deployment diagram](http://plantuml.com/deployment-diagram)
* [Timing diagram](http://plantuml.com/timing-diagram)

see the [PlantUml reference guide](http://plantuml.com/PlantUML_Language_Reference_Guide.pdf) for more details