using System;
namespace PrjTutor
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public required string Title { get; set; }
        public DateTime DueDate { get; set; }
        public AssignmentType Type { get; set; } // e.g., Homework, Test, InClass
        public double Weight { get; set; } // Determines how much it counts toward the final grade
        public double Grade { get; set; } // Grade received for this assignment

        // Relationship
        public int StudentId { get; set; }
        public required Student Student { get; set; }

        public Assignment()
        {

        }
    }

}

