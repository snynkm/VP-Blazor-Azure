namespace DataAccess.Models.Order;

public class Transaction
{
    public int Id { get; set; }


    public int HolderName { get; set; }


    public int Type { get; set; }



    public string? CardNum { get; set; }



    public string? Zip { get; set; }
}
