using System;

namespace VicsEx3
{
    public class Wolf : Animal
    {

        public Wolf(string name, int age, float weight, string furcol) : base(name, age, weight)
        {
            FurColor = furcol;
        }

        public string FurColor { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Ahwooooooooo...");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Fur colour: {FurColor}";
        }
    }
}