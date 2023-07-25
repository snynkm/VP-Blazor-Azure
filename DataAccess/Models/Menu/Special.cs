using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.Menu;

public class Special
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal? PriceMod { get; set; }
    public string? Description { get; set; }
}
