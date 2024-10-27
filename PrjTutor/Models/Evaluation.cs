using System;
using PrjTutor.Models;
namespace PrjTutor
{
    public class Evaluation
    {
        public int EvaluationId {get;set;}

        public double Grade { get; set; } // Grade received for this assignment
        public string Notes {get; set;}

        // Relationship
        public int StudentId { get; set; }
        public required Student Student { get; set; }
        public int AssignmentId{get;set;}
        public required Assignment Assignment {get;set;}

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public Evaluation()
        {

        }
    }

}

