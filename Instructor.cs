using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        //properties
        //properties have a get set and are usually puplic
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slack { get; set; }
        public Cohort InstructorCohort { get; set; }
        public string InstructorSpecialty { get; set; }
        public List<Exercise> InstructorExercise { get; set; }
        public string Description
        {
            get
            {
                return $"{FirstName} {LastName} {Slack} {InstructorCohort} {InstructorSpecialty} {InstructorExercise}";
            }
        }
        public Instructor(string firstName, string lastName, string slack, string instructorSpecialty)
        {
            FirstName = firstName;
            LastName = lastName;
            Slack = slack;
            InstructorSpecialty = instructorSpecialty;
        }

        public void AssignExerciseToStudent(Exercise exercise, Student student)
        {
            student.StudentExercises.Add(exercise);
        }
    }
}

