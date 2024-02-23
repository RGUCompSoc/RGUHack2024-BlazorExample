# RGUHack 2024 - Blazor Example

This is an example app using [.NET 8 Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) and the [MudBlazor](https://www.mudblazor.com/) component library.

It is using the interactive server model, meaning the pages are pre-rendered, and all services and logic is executed on the server rather than in the browser.

Created using the following CLI commands:
```sh
dotnet new install MudBlazor.Templates
dotnet new mudblazor --interactivity Server --all-interactive --name <Your Project Name Here>
```

<img width="1728" alt="image" src="https://github.com/RGUCompSoc/RGUHack2024-BlazorExample/assets/20544390/cd88c70f-95d2-4ffe-b41f-29ada90fd312">

## Useful Resources

These are some useful resources if you intend on working with Blazor during the hack. Feel free to find Reece at the hack if you have more questions as you go!

- https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor - Microsoft's introduction to Blazor.
- https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro - Blazor introductory tutorial.
- https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection - Documentation for Dependency Injection
- https://learn.microsoft.com/en-us/aspnet/entity-framework - Entity Framework; you can use this to write database queries in Linq, consider using Sqlite or something instead of SQL Server for ease of setup during the hack.
- https://www.mudblazor.com/ - The component library used in this example
- https://antblazor.com/ - Another component library
- https://www.fluentui-blazor.net/ - Another component library

## Alternatives

If you don't fancy using Blazor for you app, you can always consider these alternatives:

- https://ejs.co/ - Taught during RGU classes
- https://vuejs.org/ - Jordan will be speaking about this one!
- https://react.dev/ - consider mixing with something like https://nextjs.org/
- https://flutter.dev/ - Modern Web, Mobile and Desktop Applications!
- HTML/CSS/JS - classic style!
- Anything else you may already know!
