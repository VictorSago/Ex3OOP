using System;

namespace VicsEx3
{
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, float weight, string furcol) : base(name, age, weight, furcol)
        {
        }

        public void Talk()
        {
            Console.WriteLine($"My name is {Name.Split()[0]}, and I have a problem. :(");
        }
    }
}