# Basic Templates

A Dotnet New item template plugin for generating basic files.

## Install

    dotnet new -i BasicTemplates

## Uninstall

    dotnet new -u BasicTemplates

## Quickstart: Create a Public Class

    dotnet new class -A public -R abstract -N MyNamespace.Models -o ./Models -n MyAwesomeModel

Creates the file `./Models/MyAwesomeModel.cs`

    using System;

    namespace Basic.Templates
    {
        public class Basic
        {
        }
    }

Other basic C# types are supported.

    dotnet new class --help
    dotnet new interface --help
    dotnet new record --help
    dotnet new struct --help

## Additional Command Arguments

### Namespace

`--Namespace` (`-N`) sets the namespace in the generated file.

### Access Modifier

`--AccessModifier` (`-A`) sets the type's access level. Only `internal` or `public`
can be used for namespace level types.

### Reference Modifier

`--ReferenceModifier` (`-R`) sets the modifiers related to inheritance. The choices
are `abstract`, `sealed`, and `static`. These are only available for the reference
types, `class` and `record`.
