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
            Console.WriteLine("Tweet-tweet! Chirp-chirp!");
            
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Wing span: {WingSpan} cm";
        }

    }
}