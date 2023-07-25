namespace DataAccess.Models.Customer;

public class Guest : Customer
{
    public Guest()
    {
        
    }
    public Guest(string? fName, string? lName, string? ph, string? email, string? address, string? city, int? state, string? zip)
    {
        FirstName = fName;
        LastName = lName;
        Phone = ph;
        Email = email;
        AddressLine = address;
        City = city;
        StateId = state;
        Zip = zip;
    }
}
