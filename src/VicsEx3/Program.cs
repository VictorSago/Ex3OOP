using System;

namespace VicsEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreatePersons();
            var ph = new PersonHandler();
            var p1 = ph.CreatePerson("Zaphod", "Beeblebrox", 120, 210, 100);
            var p2 = ph.CreatePerson("Ford", "Prefect", 110, 180, 90);
            var p3 = ph.CreatePerson("Arthur", "Dent", 36, 190, 85);
            var p4 = ph.CreatePerson("Trillian", "McMillan", 28, 172, 58);
            var p5 = ph.CreatePerson("Marvin", "ParanoidAndroid", 120000, 120, 300);
            Console.WriteLine($"P1: {ph.Describe(p1)}");
            Console.WriteLine($"P2: {ph.Describe(p2)}");
            Console.WriteLine($"P3: {ph.Describe(p3)}");
            Console.WriteLine($"P4: {ph.Describe(p4)}");
            Console.WriteLine($"P5: {ph.Describe(p5)}");
            
        }

        private static void CreatePersons()
        {
            try
            {
                var p1 = new Person("Arthur", "Dent", 32);
                Console.WriteLine(p1.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Person p1 inte skapades: " + ex.Message);
            }

            try
            {
                var p2 = new Person("Ford", "Prefect", 0);
                Console.WriteLine(p2.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Person p2 inte skapades: " + ex.Message);
            }

            try
            {
                var p3 = new Person("Zaphod", "Bb", 320);
                Console.WriteLine(p3.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Person p3 inte skapades: " + ex.Message);
            }
            
            try
            {
                var p4 = new Person("Marvin", "The Paranoid Android", 456000000);
                Console.WriteLine(p4.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Person p4 inte skapades: " + ex.Message);
            }

            try
            {
                var p5 = new Person("", "Slartibartfast", 3264);
                Console.WriteLine(p5.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Person p5 inte skapades: " + ex.Message);
            }

            try
            {
                var p6 = new Person("Tricia Marie", "McMillan", 28);
                Console.WriteLine(p6.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Person p6 inte skapades: " + ex.Message);
            }
        }
    }
}
