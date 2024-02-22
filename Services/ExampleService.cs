using System.Globalization;
using BlazorExample.Models;
using CsvHelper;

namespace BlazorExample.Services;

/// <summary>
/// This is an example of a service.
/// This will be dependency-injected into our Registrations page.
/// See Program.cs line 13 for how to register services.
/// Learn more: https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection.
/// </summary>
public class ExampleService
{
    public async Task<IList<RGUHackRegistrationDto>> GetAllRegistrationsAsync()
    {
        // Simulate asynchronous loading to demonstrate a loading indicator
        // This is where you would use an API or a Database - check out John's API workshop for more on that!
        await Task.Delay(500);

        // Load our attendee data from the CSV file.
        // Uses a popular "NuGet" package, CsvHelper.
        using var csv = new CsvReader(new StreamReader("attendee-data.csv"), CultureInfo.CurrentCulture);
        return await csv.GetRecordsAsync<RGUHackRegistrationDto>().ToListAsync();
    }
}