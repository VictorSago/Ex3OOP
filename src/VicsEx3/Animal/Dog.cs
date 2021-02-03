using System;

namespace VicsEx3
{
    public class Dog : Animal
    {
        
        public Dog(string name, int age, float weight, string breed) : base(name, age, weight)
        {
            Breed = breed;
        }

        public string Breed { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Woof, woof!");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Breed: {Breed}";
        }

        public string Unique()
        {
            return $"Hash:{this.GetHashCode().ToString()}?#@gArbLed!";
        }
    }
}