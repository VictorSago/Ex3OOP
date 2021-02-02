namespace VicsEx3
{
    public class PersonHandler
    {
        // Depending on the intended use of this class, 
        // the methods in it should probably be static
        public Person CreatePerson(string fname, string lname, int age, double height, double weight)
        // The age follows the name, not precedes it
        {
            return new Person(fname, lname, age, height, weight);
        }

        // We can return the full name of a person,
        // but we prefer to set fName and lName separately
        public string GetName(Person p) => p.FName + " " + p.LName;
        public void SetFirstName(Person p, string fName)
        {
            p.FName = fName;
        }
        public void SetLastName(Person p, string lName)
        {
            p.LName = lName;
        }

        public int GetAge(Person p) => p.Age;
        public void SetAge(Person p, int age)
        {
            p.Age = age;
        }

        public double GetHeight(Person p) => p.Height;
        public void SetHeight(Person p, double height)
        {
            p.Height = height;
        }

        public double GetWeight(Person p) => p.Weight;
        public void SetWeight(Person p, double weight)
        {
            p.Weight = weight;
        }

        public string Describe(Person p)
        {
            return p.ToString();
        }
    }
}