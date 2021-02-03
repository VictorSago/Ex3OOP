using System;

namespace VicsEx3
{
    public class Hedgehog : Animal
    {
        
        public Hedgehog(string name, int age, float weight, long nspikes) : base(name, age, weight)
        {
            NrOfSpikes = nspikes;
        }

        public long NrOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Snuffle, grunt! Snuffle, grunt!");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Number of spikes: {NrOfSpikes}";
        }
    }
}