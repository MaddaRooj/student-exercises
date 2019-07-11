using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Cohort
    {
        public string CohortName { get; set; }
        public List<string> CohortStudents { get; set; }
        public List<string> CohortInstructors { get; set; }
        public Cohort(string cohort)
        {
            CohortName = cohort;
        }
    }
}