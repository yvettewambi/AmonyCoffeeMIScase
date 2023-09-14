using System.ComponentModel.DataAnnotations.Schema;

namespace AmonyCoffeeMIS.Data.Entities;
public class Farmer
{
    public int Id { get; set; }

    public string Name { get; set; }

    
    public DateTime? DateOfBirth { get; set; }

    public string? Location { get; set; }

    public Gender Gender { get; set; }

    public List<Delivery> Deliveries { get; set; } = new List<Delivery>();

    [NotMapped]
    public int Age => DateOfBirth.HasValue ? DateTime.Now.Year - DateOfBirth.Value.Year : 0;
}

public enum Gender
{
   Unknown, Male, Female
}

