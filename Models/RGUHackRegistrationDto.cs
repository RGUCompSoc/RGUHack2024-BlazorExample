using CsvHelper.Configuration.Attributes;

namespace RGUHackBlazorWeather.Models;

public class RGUHackRegistrationDto
{
    [Index(0)]
    public DateTime OrderDate { get; set; }
    
    [Index(1)]
    public string EducationLevel { get; set; }
    
    [Index(2)]
    public string DietaryRequirements { get; set; }
    
    [Index(3)]
    public bool ShouldBeContacted { get; set; }
    
    [Index(4)]
    public string YearOfStudy { get; set; }
}