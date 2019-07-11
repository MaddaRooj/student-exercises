using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Exercise
    {
        public string ExerciseName { get; set; }
        public string ExerciseLanguage { get; set; }
        public Exercise(string exercise, string language)
        {
            ExerciseName = exercise;
            ExerciseLanguage = language;
        }
    }
}