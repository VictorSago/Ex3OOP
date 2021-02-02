using System;

namespace VicsEx3
{
    public class Person
    {
        private string fName;
        private string lName;
        private int age;
        private double height;
        private double weight;
        
        // The age of the person should follow the name, not precede it
        public Person(string fName, string lName, int age)
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = 0.0;
            Weight = 0.0;
        }

        public Person(string fName, string lName, int age, double height, double weight)
        {
            FName = fName;
            LName = lName;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public string FName
        {
            get => fName;
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException($"FName {nameof(value)} must be between 2 and 10 characters long.");
                }
                fName = value;
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException($"LName {nameof(value)} must be between 3 and 15 characters long.");
                }
                lName = value;
            }
        }

        public int Age
        { 
            get => age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Age {nameof(value)} must be greater than 0.");
                }
                age = value;
            } 
        }

        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return $"First Name = {FName}, Last Name = {LName}, Age = {Age} years, Height = {Height} cm, Weight = {Weight} kg;";
        }
    }
}