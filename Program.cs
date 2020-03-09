using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //COHORTS
            Cohort myCohort36 = new Cohort("Cohort36", 23, 4);
            Cohort myCohort37 = new Cohort("Cohort37", 27, 3);
            Cohort myCohort38 = new Cohort("Cohort38", 29, 5);
            Cohort myCohort39 = new Cohort("Cohort39", 26, 2);

            Exercise myExercise1 = new Exercise("Classes", "C#");
            Exercise myExercise2 = new Exercise("Methods", "JavaScript");
            Exercise myExercise3 = new Exercise("Hooks", "React");
            Exercise myExercise4 = new Exercise("Fetch Calls", "Python");

            Student myStudent1 = new Student("Lauren", "Riddle", "@LaurenRiddle");
            Student myStudent2 = new Student("Philip", "Martin", "@PhilipMartin");
            Student myStudent3 = new Student("Matt", "Reeds", "@MattReeds");
            Student myStudent4 = new Student("Brant", "Pippin", "@BrantPippin");
            myStudent1.StudentCohort = myCohort36;
            myStudent2.StudentCohort = myCohort37;
            myStudent3.StudentCohort = myCohort38;
            myStudent4.StudentCohort = myCohort39;

            Instructor myInstructor1 = new Instructor("Steve", "Brownlee", "@SteveBrownlee", "Dad Jokes");
            Instructor myInstructor2 = new Instructor("Adam", "Sheaffer", "@AdamSheaffer", "C#");
            Instructor myInstructor3 = new Instructor("Joe", "Shepherd", "@JoeShepherd", "Voice Acting");
            Instructor myInstructor4 = new Instructor("Mo", "Silvera", "@MoSilvera", "Everything");
            myInstructor1.InstructorCohort = myCohort39;
            myInstructor2.InstructorCohort = myCohort37;
            myInstructor3.InstructorCohort = myCohort36;
            myInstructor4.InstructorCohort = myCohort38;

            myInstructor1.AssignExerciseToStudent(myExercise2, myStudent4);
            myInstructor2.AssignExerciseToStudent(myExercise1, myStudent2);
            myInstructor3.AssignExerciseToStudent(myExercise4, myStudent1);
            myInstructor4.AssignExerciseToStudent(myExercise3, myStudent3);

            Console.WriteLine("****Cohorts****");

            // Console.WriteLine($"This is {myCohort36.Name}. There are {myCohort36.StudentCount} students in this Cohort. There are {myCohort36.InstructorCount} intructors in this Cohort");
            // Console.WriteLine($"This is {myCohort37.Name}. There are {myCohort37.StudentCount} in this Cohort. There are {myCohort37.InstructorCount} intructors in this Cohort");
            // Console.WriteLine($"This is {myCohort38.Name}. There are {myCohort38.StudentCount} in this Cohort. There are {myCohort38.InstructorCount} intructors in this Cohort");

            Console.WriteLine("****Exercises****");

            // Console.WriteLine($"This exercise is on {myExercise1.Name} In {myExercise1.Language}");
            // Console.WriteLine($"This exercise is on {myExercise2.Name} In {myExercise2.Language}");
            // Console.WriteLine($"This exercise is on {myExercise3.Name} In {myExercise3.Language}");
            // Console.WriteLine($"This exercise is on {myExercise4.Name} In {myExercise4.Language}");

            Console.WriteLine("****Students****");

            Console.WriteLine($"Im {myStudent1.FirstName} {myStudent1.LastName} My Slack is {myStudent1.Slack} Im apart of {myStudent1.StudentCohort.Name} My exercises are {myStudent1.StudentExercises}");
            Console.WriteLine($"Im {myStudent2.FirstName} {myStudent2.LastName} My Slack is {myStudent2.Slack} Im apart of {myStudent1.StudentCohort.Name} My exercises are {myStudent1.StudentExercises}");
            Console.WriteLine($"Im {myStudent3.FirstName} {myStudent3.LastName} My Slack is {myStudent3.Slack} Im apart of {myStudent1.StudentCohort.Name} My exercises are {myStudent1.StudentExercises}");
            Console.WriteLine($"Im {myStudent4.FirstName} {myStudent4.LastName} My Slack is {myStudent4.Slack} Im apart of {myStudent1.StudentCohort.Name} My exercises are {myStudent1.StudentExercises}");

            Console.WriteLine("****Students****");

            Console.WriteLine($"Im {myInstructor1.FirstName} {myInstructor1.LastName} My Slack is {myInstructor1.Slack} My specialty is {myInstructor1.InstructorSpecialty} I teach {myInstructor1.InstructorCohort}");
            Console.WriteLine($"Im {myInstructor2.FirstName} {myInstructor2.LastName} My Slack is {myInstructor2.Slack} My specialty is {myInstructor2.InstructorSpecialty} I teach {myInstructor2.InstructorCohort}");
            Console.WriteLine($"Im {myInstructor3.FirstName} {myInstructor3.LastName} My Slack is {myInstructor3.Slack} My specialty is {myInstructor3.InstructorSpecialty} I teach {myInstructor3.InstructorCohort}");
            Console.WriteLine($"Im {myInstructor4.FirstName} {myInstructor4.LastName} My Slack is {myInstructor4.Slack} My specialty is {myInstructor4.InstructorSpecialty} I teach {myInstructor4.InstructorCohort}");
        }
    }
}
