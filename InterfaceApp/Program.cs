namespace InterfaceLesson;

class Program
{
    static void Main(string[] args)
    {
        Dog aDog = new Dog("aki");
        aDog.AnimalTag();
        aDog.MakeSound();
        aDog.Eat("Balanced food");
        Cat aCat = new Cat("Matu");
        aCat.AnimalTag();
        aCat.Eat("Cat nip");
        aCat.MakeSound();
    }
    public interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
        void AnimalTag();
    }

    public class Cat : IAnimal
    {
        private string _catName { get; }
        public Cat(string catName)
        {
            _catName = catName;
        }
        public void AnimalTag()
        {
            Console.WriteLine($"My name is {_catName}");
        }
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{_catName} eats " +food);
        }
    }

    public class Dog : IAnimal
    {
        private string _dogName { get; }
        public Dog(string catName)
        {
            _dogName = catName;
        }
        public void AnimalTag()
        {
            Console.WriteLine($"My name is {_dogName}");
        }
        //needs to implement the interfaces methods
        public void Eat(string food)
        {
            System.Console.WriteLine($"{_dogName} eats "+food);
        }

        public void MakeSound()
        {
            System.Console.WriteLine("Bark");
        }
    }

}