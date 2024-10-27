using Microsoft.AspNetCore.Identity;

namespace PrjTutor.Models
{
    public class ApplicationUser: IdentityUser {
        public String FirstName {get; set;} = "";
        public String LastName { get; set;} = "";
        public DateTime CreatedAt {get;set;}

        public ICollection<Student> Students {get;set;} = new List<Student>();
        public ICollection<Assignment> Assignments {get;set;} = new List<Assignment>();
    }
}