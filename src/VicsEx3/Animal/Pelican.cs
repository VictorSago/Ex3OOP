using System;

namespace VicsEx3
{
    public class Pelican : Bird
    {
        public Pelican(string name, int age, float weight, float wspan) : base(name, age, weight, wspan)
        {
        }

        public float BeekVolume { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Beek volume: {BeekVolume} cubic cm";
        }
    }
}