using System;

namespace VicsEx3
{
    public class Worm : Animal
    {
        
        public Worm(string name, int age, float weight, bool poisonous) : base(name, age, weight)
        {
            IsPoisonous = poisonous;
        }

        public bool IsPoisonous { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Sssss...");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is poisonous: {IsPoisonous}";
        }
    }
}