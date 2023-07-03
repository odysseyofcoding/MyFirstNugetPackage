namespace MyFirstNuget
{
    public class Dog : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Dog(int age, string name, string description)
        {
            this.Age = age;
            this.Name = name;
            this.Description = description;
        }
        public void MakeNoise()
        {
            Console.WriteLine("Wuff");
        }
        public void ShowDescription()
        {
            Console.WriteLine(Description);
        }
    }

    public class Cat : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Cat(int age, string name, string description)
        {
            this.Age = age;
            this.Name = name;
            this.Description = description;
        }

        public void MakeNoise()
        {
            Console.WriteLine("Miau");
        }

        public void ShowDescription()
        {
            Console.WriteLine(Description);
        }
    }

    public interface IAnimal
    {
        public void MakeNoise();

        public void ShowDescription();
    }
}
