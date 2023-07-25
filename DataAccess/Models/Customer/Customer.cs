using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.Customer;

public class Customer
{
    public int Id { get; set; }

    [MaxLength(25, ErrorMessage = "Name cannot exceed 25 characters")]
    [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Name can contain only letters")]
    public string? FirstName { get; set; }
    
    [MaxLength(25, ErrorMessage = "Name cannot exceed 25 characters")]
    [RegularExpression("^[a-zA-Z\\s\\-]+$", ErrorMessage = "Name can contain only letters")]
    public string? LastName { get; set; }
    
    [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must be exactly 8 digits long. I.e. Format = '8008880000'")]
    [RegularExpression("^[0-9]+$", ErrorMessage = "Phone number can contain only numbers")]
    public string? Phone { get; set; }

    public string? Email { get; set; }

    [RegularExpression("^[a-zA-Z0-9\\s]+$", ErrorMessage = "Address can contain only letters and numbers")]
    [MaxLength(35, ErrorMessage = "Address cannot exceed 35 characters")]
    public string? AddressLine { get; set; }

    [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "City can only contain letters")]
    [MaxLength(25, ErrorMessage = "City cannot exceed 25 characters")]
    public string? City { get; set; }
    
    public int? StateId { get; set; }

    [RegularExpression("^[0-9\\-]+$", ErrorMessage = "Zip code can contain only numbers")]
    public string? Zip { get; set; }

    public Customer()
    {
        
    }
}
