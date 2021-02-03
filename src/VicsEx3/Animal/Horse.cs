using System;

namespace VicsEx3
{
    public class Horse : Animal
    {
        
        public Horse(string name, int age, float weight, int height) : base(name, age, weight)
        {
            Height = height;
        }

        public int Height { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Neigh, neigh!");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Height: {Height} cm";
        }
    }
}