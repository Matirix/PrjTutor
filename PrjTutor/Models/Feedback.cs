using System;
namespace PrjTutor
{
    public class Feedback
    {
        public required int FeedbackId { get; set; }
        public DateTime WeekEnding { get; set; }
        public string? Strength { get; set; }
        public string? Weakness { get; set; }
        public string? Performance { get; set; }
        public string? LearningObjective { get; set; }

        // Relationship
        public int StudentId { get; set; }
        public required Student Student { get; set; }

        public Feedback()
        {

        }
    }

}

