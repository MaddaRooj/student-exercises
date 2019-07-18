using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort StudentCohort { get; set; }
        public List<Exercise> StudentExercises { get; set; }
        public Student(string firstname, string lastname, string slackhandle, Cohort cohort)
        {
            FirstName = firstname;
            LastName = lastname;
            SlackHandle = slackhandle;
            StudentCohort = cohort;
            StudentExercises = new List<Exercise>();
        } 
    }
}