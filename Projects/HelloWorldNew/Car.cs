namespace HelloWorld;
//Creating Car based on OOP section in Udemy
internal class Car
{
    public Car()
    {
    }
    public static int NumberOfCars = 0;
    /* fields are prefaced with "_"
     variables initiated outside of methods, are fields.
    */
    // These are backing fields because another variable will be used to modify
    private string _model = "";
    private string _brand = ""; // Encapsulate field -> and use property. (Generate -> Property)
    public bool IsLuxury { get; } = false; //encapsulate

    //creating a Property, this should be the only way to edit _model & _brand
    public string Model
    {
        get => _model;
        set => _model = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    /*
     * As seen in the property below.
     * This kind of code allows us to add more information and conditions to a simple variable.
     * Brand not only can be reassigned, but it has instructions for how it should be reassigned depending on
     * the input provided. (Ex. being null)
     */
    public string Brand
    {
        get
        {
            if (IsLuxury)
            {
                return _brand + " - Luxury Edition";
            }
            else
            {
                return _brand;
            }
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You've entered null or empty.");
            }
            else
            {
                _brand = value;
            }
        }
    }
    
    
    //Constructor: No return type, same name as Class
    public Car(string model, string brand, bool isLuxury)
    {
        NumberOfCars++;
        Model = model; //Change _model to Model in order to protect our variables.
        Brand = brand;
        Console.WriteLine($"Created {model} {brand} successfully.");
        IsLuxury = isLuxury;
    }
}
