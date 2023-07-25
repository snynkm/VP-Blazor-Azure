namespace DataAccess.Models.Branch;

public class Branch
{
    public int Id { get; set; }
    public string? City { get; set; }
    public string? AddressLine { get; set; }
    public int? StateId { get; set; }
    public string? Zip { get; set; }
    public string? Phone { get; set; }

}
