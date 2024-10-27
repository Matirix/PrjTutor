using Microsoft.AspNetCore.Identity;

namespace PrjTutor.Models
{
    public class ApplicationUser: IdentityUser {
        public String FirstName {get; set;} = "";
        public String LastName { get; set;} = "";
        public DateTime CreatedAt {get;set;}
    }
}