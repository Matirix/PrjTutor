using System;
using PrjTutor.Models;
namespace PrjTutor
{
    public class Assignment
    {

        public int AssignmentId { get; set; }
        public required string Title { get; set; }
        public DateTime DueDate { get; set; }
        public AssignmentType Type { get; set; } // e.g., Homework, Test, InClass
        
        // Foreign key for the tutor
        public string UserId { get; set; }
        
        // Navigation property
        public ApplicationUser User { get; set; }


        // Relationship
        public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();


        public Assignment()
        {

        }
    }

}

