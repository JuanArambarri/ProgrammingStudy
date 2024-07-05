namespace HelloWorld;

public class Customer
{
    //static field to hold the next ID available (Identifiers)
    private static int nextID = 0;

    private readonly int _id; //unique identifier || Readonly = does not have a setter. (for non-overrideable)
    
    public int ID //makes the Id accessible from outside this class
    {
        get => _id;
    }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    
    //Custom contructor (multiple)
    // if a parameter has a default value, it becomes an optional parameter
    public Customer(string name, string address, string contactNumber = "Not Registered")
    {
        _id = nextID++;
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public Customer(string name)
    {
        _id = nextID++;
        Name = name;
    }
    // for default values, nothing passed
    public Customer()
    {
        _id = nextID++;
        Name = "DefaultName";
        Address = "No address";
        ContactNumber = "No contact number";
    }
    //method(function) in order to be able to set details after a creation.
    public void SetDetails(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public void customerDetails()
    {
        Console.WriteLine($"The id for {this.Name} is {this._id}");
    }
}