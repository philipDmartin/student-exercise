using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        //properties
        //properties have a get set and are usually puplic
        public string Name { get; set; }
        public int StudentCount { get; set; }
        public int InstructorCount { get; set; }
        public string Description
        {
            get
            {
                return $"{Name} {StudentCount} {InstructorCount}";
            }
        }

        public Cohort(string name, int studentCount, int instructorCount)
        {
            Name = name;
            StudentCount = studentCount;
            InstructorCount = instructorCount;
        }
    }
}