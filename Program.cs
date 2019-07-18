using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create exercises and add to list-----------------------------------
            var exercise1 = new Exercise("C# Starter Project", "C#");
            var exercise2 = new Exercise("React Nutshell", "Javascript");
            var exercise3 = new Exercise("English Idioms", "C#");
            var exercise4 = new Exercise("Urban Planner", "C#");
            var exercise5 = new Exercise("Itinerary Builder", "Javascript");
            var exercise6 = new Exercise("JS Nutshell", "Javascript");
            List<Exercise> exercises = new List<Exercise>(){
                exercise1, exercise2,exercise3, exercise4, exercise5, exercise6
            };

            // Creates all cohorts------------------------------------------------
            var cohort1 = new Cohort("Day Classes - Cohort 32");
            var cohort2 = new Cohort("Day Classes - Cohort 33");
            var cohort3 = new Cohort("Day Classes - Cohort 34");
            var cohort4 = new Cohort("Night Classes - Cohort 16");
            List<Cohort> cohorts = new List<Cohort>(){
                cohort1, cohort2, cohort3, cohort4
            };

            // Creates students and adds them to the list--------------------------
            var student1 = new Student("Addam", "Joor", "addam.joor", cohort1);
            var student2 = new Student("Emily", "Loggins", "emily.loggins", cohort1);
            var student3 = new Student("Ellie", "Ash", "ellie.ash", cohort3);
            var student4 = new Student("Ben", "Parker", "ben.parker", cohort2);
            var student5 = new Student("Shelley", "Arnold", "shelley.arnold", cohort1);
            List<Student> students = new List<Student>(){
                student1, student2, student3, student4, student5
            };
            cohort1.CohortStudents.Add(student1);
            cohort1.CohortStudents.Add(student2);
            cohort1.CohortStudents.Add(student5);
            cohort3.CohortStudents.Add(student3);
            cohort2.CohortStudents.Add(student4);

            // Creates all instructors--------------------------------------------
            var instructor1 = new Instructor("Dance", "Storm", "dan.storm", cohort1, "Dancesplosion");
            var instructor2 = new Instructor("Bryan", "Nielson", "bryanfuckingnielson", cohort1, "High Five Hurricane");
            var instructor3 = new Instructor("Brenda", "Long", "brenda.long", cohort3, "Positivity Overload");
            var instructor4 = new Instructor("Adam", "Sheaffer", "adam.sheaffer", cohort2, "Hat Heard Round the World");

            foreach(Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            };

            System.Console.WriteLine();
            foreach(Exercise exercise in exercises)
            {
                Console.WriteLine($"Assignment: {exercise.ExerciseName} in {exercise.ExerciseLanguage}");
            };

            // Instructor assigns student with a specified exercise
            System.Console.WriteLine();
            instructor4.Assign(student1, exercise2);
            instructor2.Assign(student1, exercise3);
            instructor3.Assign(student2, exercise1);
            instructor1.Assign(student3, exercise4);
            instructor4.Assign(student4, exercise2);
            System.Console.WriteLine();

            // Consoles the student name followed by their respective list of assignments
            foreach(var student in students){
                System.Console.WriteLine($"{student.FirstName}'s Assignment List:");
                foreach(var exercise in student.StudentExercises){
                    System.Console.WriteLine($"{exercise.ExerciseName}");
                }
                System.Console.WriteLine();
            }

            // Select all exercises that utilize Javascript language
            var javaExercises = from exercise in exercises
                where exercise.ExerciseLanguage == "Javascript"
                select exercise;

            System.Console.WriteLine("All Javascript exercises:");
            foreach(Exercise exercise in javaExercises){
                System.Console.WriteLine(exercise.ExerciseName);
            }

            // Select all students that are in cohort 32
            System.Console.WriteLine();
            var studentsOfCohort32 = from student in students
                where student.Cohort == cohort1
                select student;

            System.Console.WriteLine("All Students in Cohort 32:");
            foreach (Student student in studentsOfCohort32){
                System.Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            // Order all students by last name
            System.Console.WriteLine();
            var sortedStudents = from student in students
                orderby student.LastName
                select student;
            System.Console.WriteLine("All students ordered by last name:");
            foreach(Student student in sortedStudents){
                System.Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            // Sort students with no exercises assigned
            System.Console.WriteLine();
            var noExercises = from student in students
                where student.StudentExercises.Count == 0
                select student;
            System.Console.WriteLine("Students with no exercises assigned:");
            foreach(Student student in noExercises){
                System.Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            // Find student with the most exercises assigned
            System.Console.WriteLine();
            var mostExercises = from student in students
                orderby student.StudentExercises.Count descending
                select student;
            System.Console.WriteLine("Student with most exercises:");
            foreach(Student student in mostExercises){
                System.Console.WriteLine($"{student.FirstName} {student.LastName} - {student.StudentExercises.Count}");
            };

            // How many students per cohort?
            System.Console.WriteLine();
            var studentCount = from cohort in cohorts
                orderby cohort.CohortStudents.Count descending
                select cohort;
            System.Console.WriteLine("Number of students per cohort:");
            foreach(Cohort cohort in studentCount){
                System.Console.WriteLine($"{cohort.CohortName} - {cohort.CohortStudents.Count}");
            };
        }
    }
}
