using System;
using System.Collections.Generic;
using System.Linq;

namespace VicsEx3
{
    /* 3.2.13 F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, 
     * i vilken klass bör vi lägga det?
     * S: Det bör läggas i klassen `Bird`, förstås.
     * 3.2.14 F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
     * S: I klassen `Animal`, så klart!
     * 3.3.9 F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
     * S: Listan deklarerad som `List<Dog>` kan bara lagra objekt av klassen `Dog` eller dess subklasser,
     * medan `Horse` är inte en subklass av `Dog`.
     * 3.3.10 F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
     * S: Alla klassers gemensamma superklass -- deras "förälder". Så, i vårt fall, om vi ska lagra alla
     * djurtyper i den, så måste listan vara av typen `List<Animal>`. Men om vi ska kunna lagra alla klasser
     * så måste listan vara deklarerad som `Object`-listan, eftersom `Object` är superklassen till ALLA klasser.
     * 3.3.13 F: Förklara vad det är som händer.
     * S: Exekveringsmiljön anropar respektive objektets `Stats()` metod. Om metoden finns överlagrad hos det objektet
     * som finns under exekveringen, så exekveras den metoden, annars kollar exekveringmiljön i nästa länk upp i
     * klasshierarkin till den hittar definitionen av metoden och kör den. I vårt fall överlagrar varje subklass i
     * hierarkin `Stats()` metoden, så det är den som exekveras.
     * 3.3.17 F: Varför inte?
     * S: För att den finns inte för alla `Animal`s -- den finns bara för `Dog`s. Från `Animal` objekt kan vi bara
     * komma åt metoder i deklarerade i `Animal` klassen eller i dess superklass(er).
     * 3.4.11 F: Varför är polymorfism viktigt att behärska?
     * S: Det tillåter att behandla objekt av olika besläktade  klasser som om de vore av samma klass. Det gör att 
     * koden blir mer dynamisk: samma kod på ett ställe kan leda till olika beteenden beroende på den konkreta 
     * implementationen. Med andra ord, ett och samma variabel kan ha olika "former" -- därav ordet polymorfism.
     * 3.4.12 F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
     * S: Koden blir mer flexibel, eftersom man oftast inte behöver ändra det på olika ställen. Koden blir också mer 
     * läsbar, eftersom man då inte behöver ta hänsyn till vad det är för objekt i varje stund och ha separat 
     * typberoende kod.
     * 3.4.13 F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
     * S: I princip, så handlar det om att en abstrakt klass bestämmer de ärvande klassernas inre struktur, medan ett
     * interface bestämmer den implementerande klassens "yttre ansikte", så att säga. I praktiken, en abstrakt klass är
     * en klass som inte instansieras, men agerar istället som en basklass för andra klasser, medan ett interface är 
     * inte en klass, utan snarare ett slags "kontrakt" för en klass. Med en abstrakt klass metoder kan vara 
     * implementerade och antingen ärvas då som de är eller överridas. I ett interface metoder är inte implementerade 
     * utan visar bara en metodsignatur, och alla klasser som implementerar interfacet måste implementera alla metoder
     * (detta kommer att ändras i framtiden när man inför s.k. "default methods").
     * En annan mycket viktig skillnad är att en klass kan bara ärva frå en basklass, men den kan implementera många
     * olika interface.
     *
     * De här frågorna och svaren kunde ha lagts i filen README.md eller i sin egen lilla textfil.
     */
     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========Persons:================================");

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

            Console.WriteLine("========End Persons=============================\n");

            Console.WriteLine("========Animal list:============================");

            var animalList = new List<Animal>();
            PopulateAnimals(animalList);
            foreach (var a in animalList)
            {
                Console.WriteLine($"{a.Name} ({a.GetType().Name})");
                if (a is IPerson)
                {
                    Console.Write(" -- ");
                    ((IPerson)a).Talk();
                }
                Console.Write("        ");
                a.DoSound();
            }
            
            Console.WriteLine("========End Animal list=========================\n");

            var doglist = new List<Dog>();
            PopulateDogs(doglist);

            Console.WriteLine("========Animal stats:===========================");

            foreach (var a in animalList)
            {
                Console.WriteLine($"{a.Stats()}");
            }

            Console.WriteLine("========End Animal stats========================\n");

            Console.WriteLine("====Stats & unique for only Dogs in Animal list:");

            foreach (var dog in animalList.OfType<Dog>().ToList())
            {
                Console.WriteLine($"{dog.Stats()}, {dog.Unique()}");
            }
            
            Console.WriteLine("==End Stats+unique for only Dogs in Animal list=\n");

            Console.WriteLine("========User errors:============================");

            var uErrorList = new List<UserError>();
            PopulateUserErrors(uErrorList);

            foreach(var ue in uErrorList)
            {
                Console.WriteLine(ue.UEMessage());
            }

            Console.WriteLine("========End User errors=========================\n");

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
    
        private static void PopulateAnimals(List<Animal> ls)
        {
            ls.Add(new Bird("Jonathan Livingston", 9, 2.5f, 70.0f));
            ls.Add(new Dog("Argos", 20, 60f, "Hunting dog"));
            ls.Add(new Hedgehog("Sonic", 4, 2.1f, 10000));
            ls.Add(new Horse("Sleipnir", 500, 2000f, 300));
            ls.Add(new Wolf("Akela", 12, 30.2f, "white"));
            ls.Add(new Worm("Sisi", 1, 0.2f, true));
            var flamingo = new Flamingo("Ruby", 18, 5.5f, 150f);
            flamingo.LegLength = 120;
            ls.Add(flamingo);
            var pelican = new Pelican("Petra", 26, 15.0f, 302f);
            pelican.BeekVolume = 750;
            ls.Add(pelican);
            ls.Add(new Wolfman("Larry Talbot", 35, 85f, "black"));
            var swan = new Swan("Odette", 19, 10f, 2.5f);
            swan.NeckLength = 90;
            ls.Add(swan);
        }

        private static void PopulateDogs(List<Dog> dl)
        {
            dl.Add(new Dog("Cerberus", 10000, 1000f, "Hellhound"));
            dl.Add(new Dog("White Fang", 4, 38f, "Wolfhound"));
            dl.Add(new Dog("Sharvara", 1000000, 120, "Ancient dog"));
            dl.Add(new Dog("Laelaps", 20, 30f, "Supreme Hunter"));
        }

        private static void PopulateUserErrors(List<UserError> uel)
        {
            uel.Add(new TextInputError());
            uel.Add(new NumericInputError());
            uel.Add(new NumericInputError());
            uel.Add(new TextInputError());
            uel.Add(new NumericInputError());
            uel.Add(new TextInputError());
            uel.Add(new DateInputError());
            uel.Add(new IntegerInputError());
            uel.Add(new DateInputError());
            uel.Add(new NumberRangeInputError());
            uel.Add(new NumberRangeInputError());
            uel.Add(new IntegerInputError());
        }
    }
}
