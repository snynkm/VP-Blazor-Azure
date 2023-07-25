namespace DataAccess.Models.Order;

public class Discount
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public char Type { get; set; }
    public decimal? PercentAmt { get; set; }
    public decimal? FlatAmt { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

}
