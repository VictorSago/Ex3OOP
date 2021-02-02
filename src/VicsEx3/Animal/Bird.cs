using System;

namespace VicsEx3
{
    public class Bird : Animal
    {
        
        public Bird(string name, int age, float weight, float wspan) : base(name, age, weight)
        {
            WingSpan = wspan;
        }

        public float WingSpan { get; set; }

        public override void DoSound()
        {
            throw new System.NotImplementedException();
        }

    }
}