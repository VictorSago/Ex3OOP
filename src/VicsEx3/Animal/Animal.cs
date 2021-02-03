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

        public virtual string Stats()
        {
            string plur = Age > 1 ? "s" : "";
            return $"{GetType().Name}: {Name}, {Age} year{plur} old, {Weight} kg";
        }
    }
}