﻿using System;
namespace PrjTutor
{
    public class Student
    {
        public int StudentId { get; set; }
        public required string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? WithdrawalDate { get; set; } // Nullable if student is still enrolled
        public required string CourseEnrolled { get; set; }

        // Relationships
        public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

        public Student()
        {

        }
    }
}

