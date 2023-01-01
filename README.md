# CSharpCodes
Sample codes for C#


## Solutions and projects
In Visual Studio, a solution isn't an "answer". 
A solution is simply a container Visual Studio uses to organize one or more related projects. 
When you open a solution, Visual Studio automatically loads all the projects that the solution contains.

We are following the one solution, multiple project approach

## Top level templates
Starting with .NET 6, the project template for new C# console apps generates the following code in the Program.cs file:
```C#
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

The new output uses recent C# features that simplify the code you need to write for a program. For .NET 5 and earlier versions, the console app template generates the following code:
```C#
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

Easy way to avoid it is to check "Do not use top-level templates" option when selecting .NET target framework!
