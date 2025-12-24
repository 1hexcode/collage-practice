namespace MauiApp1.Model;

public class Product
{
    [Required]
    public int Id {get; set;}
    [Required]
    public string ImageUrl { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [Range(0, double.MaxValue, ErrrorMessage="The price must be greater than or equal to 0.")]
    public double Price { get; set; }
    public int Likes { get; set; }
    public string Location { get; set; }
    [Required]
    [Range(1,5)]
    public int Rating { get; set; }
    [Required]
    [StringLength(100)]
    public string Description { get; set; }
}