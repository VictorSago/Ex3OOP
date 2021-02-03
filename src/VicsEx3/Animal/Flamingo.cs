using System;

namespace VicsEx3
{
    public class Flamingo : Bird
    {
        public Flamingo(string name, int age, float weight, float wspan) : base(name, age, weight, wspan)
        {
        }

        public float LegLength { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Leg length: {LegLength} cm";
        }
    }
}