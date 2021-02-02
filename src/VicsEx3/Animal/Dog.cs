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
            throw new System.NotImplementedException();
        }
    }
}