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

![Bob->Alice : hello](example.png)

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