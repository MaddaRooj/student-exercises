using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Cohort
    {
        public string CohortName { get; set; }
        public List<Student> CohortStudents { get; set; }
        public List<Instructor> CohortInstructors { get; set; }
        public Cohort(string cohort)
        {
            CohortName = cohort;
            CohortStudents = new List<Student>();
            CohortInstructors = new List<Instructor>();
        }
    }
}