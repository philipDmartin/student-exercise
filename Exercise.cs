using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Exercise
    {
        //properties
        //properties have a get set and are usually puplic
        public string Name { get; set; }
        public string Language { get; set; }
        public string Description
        {
            get
            {
                return $"{Name} {Language}";
            }
        }
        public Exercise(string name, string language)
        {
            Name = name;
            Language = language;
        }
    }
}
