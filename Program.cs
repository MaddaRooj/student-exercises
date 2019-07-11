using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create exercises and add to list-----------------------------------
            List<Exercise> exercises = new List<Exercise>();
            var exercise1 = new Exercise("C# Starter Project", "C#");
            var exercise2 = new Exercise("React Nut", "ReactJS");
            var exercise3 = new Exercise("english-idioms", "C#");
            var exercise4 = new Exercise("urban-planner", "C#");
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);
            exercises.Add(exercise4);

            // Creates all cohorts------------------------------------------------
            var cohort1 = new Cohort("Day Classes - Cohort 32");
            var cohort2 = new Cohort("Day Classes - Cohort 33");
            var cohort3 = new Cohort("Day Classes - Cohort 34");
            var cohort4 = new Cohort("Night Classes - Cohort 16");

            // Creates students and adds them to the list--------------------------
            List<Student> students = new List<Student>();
            var student1 = new Student("Addam", "Joor", "addam.joor", "Day Classes - Cohort 32");
            var student2 = new Student("Emily", "Loggins", "emily.loggins", "Day Classes - Cohort 32");
            var student3 = new Student("Ellie", "Ash", "ellie.ash", "Day Classes - Cohort 34");
            var student4 = new Student("Ben", "Parker", "ben.parker", "Day Classes - Cohort 33");
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            // Creates all instructors--------------------------------------------
            var instructor1 = new Instructor("Dance", "Storm", "dan.storm", "Day Classes - Cohort 32", "Dancesplosion");
            var instructor2 = new Instructor("Bryan", "Nielson", "bryanfuckingnielson", "Day Classes - Cohort 32", "High Five Hurricane");
            var instructor3 = new Instructor("Brenda", "Long", "brenda.long", "Day Classes - Cohort 34", "Positivity Overload");
            var instructor4 = new Instructor("Adam", "Sheaffer", "adam.sheaffer", "Day Classes - Cohort 33", "Hat Heard Round the World");

            foreach(Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            };

            foreach(Exercise exercise in exercises)
            {
                Console.WriteLine($"Assignment: {exercise.ExerciseName} in {exercise.ExerciseLanguage}");
            };
        }
    }
}
