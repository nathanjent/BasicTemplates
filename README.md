# Basic Templates

A Dotnet New item template plugin for generating basic files.

## Install

    dotnet new -i BasicTemplates

## Uninstall

    dotnet new -u BasicTemplates

## Quickstart: Create a Public Class

    dotnet new file-class --AccessModifier public --ReferenceModifier abstract --Namespace MyNamespace.Models --output ./Models --name MyAwesomeModel

Creates the file `./Models/MyAwesomeModel.cs`

    using System;

    namespace Basic.Templates
    {
        public class Basic
        {
        }
    }

## Other basic C# constructs are supported

    dotnet new file-class --help
    dotnet new file-interface --help
    dotnet new file-record --help
    dotnet new file-struct --help

