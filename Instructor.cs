using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string InstructorCohort { get; set; }
        public string InstructorSpecialMove { get; set; }
        public Instructor(string firstname, string lastname, string slackhandle, string cohort, string specialattack)
        {
            FirstName = firstname;
            LastName = lastname;
            SlackHandle = slackhandle;
            InstructorCohort = cohort;
            InstructorSpecialMove = specialattack;
        }
        public void Assign(Student student, Exercise exercise)
        {
            Console.WriteLine($"I have assigned {student.FirstName} {student.LastName} with {exercise.ExerciseName}, Muahahahaha!");
            student.StudentExercises.Add(exercise);
        }  
    }
}