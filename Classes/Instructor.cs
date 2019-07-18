using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Instructor : NSSPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string InstructorSpecialMove { get; set; }
        public Instructor(string firstname, string lastname, string slackhandle, Cohort cohort, string specialattack)
        {
            FirstName = firstname;
            LastName = lastname;
            SlackHandle = slackhandle;
            Cohort = cohort;
            InstructorSpecialMove = specialattack;
        }
        public void Assign(Student student, Exercise exercise)
        {
            Console.WriteLine($"I, {FirstName} {LastName}, have assigned {student.FirstName} {student.LastName} with {exercise.ExerciseName}, Muahahahaha!");
            student.StudentExercises.Add(exercise);
        }  
    }
}