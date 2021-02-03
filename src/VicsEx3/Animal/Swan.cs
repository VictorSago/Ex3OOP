using System;

namespace VicsEx3
{
    public class Swan : Bird
    {
        public Swan(string name, int age, float weight, float wspan) : base(name, age, weight, wspan)
        {
        }

        public float NeckLength { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Neck length: {NeckLength} cm";
        }
    }
}