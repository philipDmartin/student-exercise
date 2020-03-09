using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        //properties
        //properties have a get set and are usually public
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slack { get; set; }
        public Cohort StudentCohort { get; set; }
        public List<Exercise> StudentExercises { get; set; } = new List<Exercise>();
        public string Description
        {
            get
            {
                return $"{FirstName} {LastName} {Slack} {StudentCohort.Name}";
            }
        }
        public Student(string firstName, string lastName, string slack)
        {
            FirstName = firstName;
            LastName = lastName;
            Slack = slack;
        }
    }
}