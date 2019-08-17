# Basic Templates

A Dotnet New item template plugin for generating basic files.

## Install

    dotnet new -i BasicTemplates

## Uninstall

    dotnet new -u BasicTemplates

## Quickstart: Create a Public Class

    dotnet new code -A public -F class -o -N MyNamespace.Models -o ./Models -n MyAwesomeModel

Creates the file ./Models/MyAwesomeModel.cs
    
    using System;

    namespace Basic.Templates
    {
        public class Basic
        {
        }
    }

# Other basic C# constructs are supported

    dotnet new code --help

