using System;
namespace PrjTutor
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public required string Title { get; set; }
        public DateTime DueDate { get; set; }
        public AssignmentType Type { get; set; } // e.g., Homework, Test, InClass


        // Relationship
        public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();


        public Assignment()
        {

        }
    }

}

