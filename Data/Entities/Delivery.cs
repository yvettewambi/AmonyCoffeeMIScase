using System.ComponentModel.DataAnnotations;

namespace AmonyCoffeeMIS.Data.Entities;

public class Delivery
{
    public int Id { get; set; }

    [Range(0, double.MaxValue)]
    public double Quantity { get; set; }

    [Range(0, double.MaxValue)]
    public double Price { get; set; }

    public double Amount { get; set; }

    public DateTime DeliveryDateTime { get; set; }

    [Required]
    public int FarmerId { get; set; }

    public Farmer? Farmer { get; set; }
}
