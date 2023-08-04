using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models.Menu;

public class MenuItemDTO
{

    [Column("MenuItemIds")]
    public IEnumerable<int>? MenuItemIds { get; set; }

    [Column("CategoryId")]
    public int CategoryId { get; set; }

    [Column("CategoryName")]
    public string? CategoryName { get; set; }

    [Column("CategoryDescription")]
    public string? CategoryDescription { get; set; }


    [Column("SizeIds")]
    public IEnumerable<int>? SizeIds { get; set; }

    [Column("SizeId")]
    public int SizeId { get; set; }

    [Column("SizeNames")]
    public IEnumerable<string>? SizeNames { get; set; }



    [Column("SpecialId")]
    public int? SpecialId { get; set; }

    [Column("SpecialName")]
    public string? SpecialName { get; set; }

    [Column("SpecialDescription")]
    public string? SpecialDescription { get; set; }

    [Column("ImageTage")]
    public string? ImageTag { get; set; }

    [Column("Prices")]
    public IEnumerable<decimal>? Prices { get; set; }

    [Column("Price")]
    public decimal? Price { get; set; }

}

