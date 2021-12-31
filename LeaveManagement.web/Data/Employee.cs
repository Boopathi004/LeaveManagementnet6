using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.web.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string? TaxId { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateofJoin { get; set; }

            
    }
}
