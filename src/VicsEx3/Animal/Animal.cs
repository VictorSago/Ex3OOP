namespace VicsEx3
{
    public abstract class Animal
    {

        protected Animal(string name, int age, float weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }

        public abstract void DoSound();
    }
}