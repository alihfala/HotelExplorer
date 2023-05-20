namespace lab6Dotnet.Models;
using System.ComponentModel.DataAnnotations;

public class HotelsModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public int Rooms { get; set; }
    public string Phone { get; set; } 
    public double Rating { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }

}