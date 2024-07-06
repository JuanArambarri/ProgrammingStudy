namespace InterfaceLesson;

class Program
{
    public interface IPaymentProcesser
    {
        void ProcessPayment(decimal amount);
        
    }

    public class CreditCardProcessor : IPaymentProcesser
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment of: $" +amount);
        }
    }
    public class PaypalProcessor : IPaymentProcesser
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing Paypal payment of: $" +amount);
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcesser _processor;
        //takes any type of payment processor thanks to the interface IPayment...
        public PaymentService(IPaymentProcesser processor)
        {
            _processor = processor;
        }

        public void ProccessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }
    
    static void Main(string[] args)
    {
        //using interface to create to different classes
        IPaymentProcesser creditCardProcessor = new CreditCardProcessor();
        PaymentService paymentService = new PaymentService(creditCardProcessor);
        paymentService.ProccessOrderPayment(100m);
        IPaymentProcesser paypalProcessor = new PaypalProcessor();
        paymentService = new PaymentService(paypalProcessor);
        paymentService.ProccessOrderPayment(200m);
        
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