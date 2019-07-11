using System;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var exercise1 = new Exercise("C# Starter Project", "C#");
            var exercise2 = new Exercise("React Nut", "ReactJS");
            var exercise3 = new Exercise("english-idioms", "C#");
            var exercise4 = new Exercise("urban-planner", "C#");

            var cohort1 = new Cohort("Day Classes - Cohort 32");
            var cohort2 = new Cohort("Day Classes - Cohort 33");
            var cohort3 = new Cohort("Day Classes - Cohort 34");
            var cohort4 = new Cohort("Night Classes - Cohort 16");

            var student1 = new Student("Addam", "Joor", "addam.joor", "Day Classes - Cohort 32");
            var student2 = new Student("Emily", "Loggins", "emily.loggins", "Day Classes - Cohort 32");
            var student3 = new Student("Ellie", "Ash", "ellie.ash", "Day Classes - Cohort 34");
            var student4 = new Student("Ben", "Parker", "ben.parker", "Day Classes - Cohort 33");

            var instructor1 = new Instructor("Dance", "Storm", "dan.storm", "Day Classes - Cohort 32", "Dancesplosion");
            var instructor2 = new Instructor("Bryan", "Nielson", "bryanfuckingnielson", "Day Classes - Cohort 32", "High Five Hurricane");
            var instructor3 = new Instructor("Brenda", "Long", "brenda.long", "Day Classes - Cohort 34", "Positivity Overload");
            var instructor4 = new Instructor("Adam", "Sheaffer", "adam.sheaffer", "Day Classes - Cohort 33", "Hat Heard Round the World");
        }
    }
}
