using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Threading.Channels;

namespace HelloWorld
{
 class Program
 {
  public delegate bool FilterDelegate(Person p); //Delegate which takes a person object and returns a bool
  
  // www.dofactory.com/reference/csharp-coding-standards
  static void Main(string[] args)
  {
   //Challenges.DateRelatedInformation();
   //Delegates
   Person p1 = new Person("Aiden", 41 );
   Person p2 = new Person("Sif", 69);
   Person p3 = new Person("Walter", 12);
   Person p4 = new Person("Anatoli", 25);

   List<Person> people = new List<Person>() { p1, p2, p3, p4 };
   
   DisplayPeople("Kids", people, IsMinor);
   DisplayPeople("Senior",people,IsSenior);
   
   //inheritance
   Manager carl = new Manager("Carl", 45, "Manager", 123123, 7);
   carl.DisplayManagerInfo();
   carl.BecomeOlder(15);
   Console.ReadKey();
   
   PrintStudents(); 
   Dictionary<int, Employee> employees = new Dictionary<int, Employee>(); //instead of string, we save an object
   int indexKey = 0;

   employees.Add(indexKey, new Employee("John", 27, 1000));
   indexKey++;
   employees.Add(indexKey, new Employee("Martin", 35, 2500));
   indexKey++;
   employees.Add(indexKey, new Employee("Ceasar", 55, 4000));
   
   int age;
   string ageString = Console.ReadLine();
   if (!int.TryParse(ageString, out age))
   {
    throw new Exception("What are you doing mate?");//program crashes but a message is displayed.
   }
   
   var codes = new Dictionary<string, string>
   {
    ["NY"] = "New York", //Key has to be between squared brackets
    ["CA"] = "California",
    ["TX"] = "Texas"
   };
   //how to not crash your app when there's no value
   if (codes.TryGetValue("IN", out string state)) //we are getting the second string for Key "NY"
   {
    Console.WriteLine(state);
   }
   foreach (var item in codes)
   {
    Console.WriteLine("The state code for " + item.Value + " is " + item.Key);
   }
  }
  public class Student
  {
   public int ID { get; set; }
   public string Name { get; set; }
   public int Grade { get; set; }

   public Student(int id, string name, int grade)
   {
    ID = id;
    Name = name;
    Grade = grade;
   }
  }
  static void PrintStudents()
  {
   Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
   studentDictionary.Add("John", new Student(1, "John", 85));
   studentDictionary.Add("Alice", new Student(2, "Alice", 90));
   studentDictionary.Add("Bob", new Student(3, "Bob", 78));

   foreach (var student in studentDictionary)
   {
    Console.WriteLine("Name: " + student.Value.Name + ", Id: " + student.Value.ID + ", Grade: " + student.Value.Grade);
   }
  }
  public class Person
  {
   public string Name { get; private set; }
   public int Age { get; private set; }

   // Base class constructor
   public Person(string name, int age)
   {
    Name = name;
    Age = age;
   }

   public void DisplayPersonInfo()
   {
    Console.WriteLine($"Name: {Name}, Age: {Age}");
   }
   /// <summary>
   /// Determines the increase in age based on an input "int years"
   /// </summary>
   /// <param name="years"> Number that will be added to the age already present at the moment of initiation</param>
   /// <returns>Returns new age after being added by an int</returns>
   public int BecomeOlder(int years)
   {
    Age = Age + years;
    return Age;
   }
  }

  static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
  {
   Console.WriteLine(title);
   foreach (Person p in people)
   {
    if (filter(p))
    {
     Console.WriteLine("{0}, {1} years old.", p.Name, p.Age);
    }
   }
  }
  //Filters ----------------------------------------------------
  static bool IsMinor(Person p)
  {
   return p.Age < 18;
  }
  static bool IsAdult(Person p)
  {
   return p.Age >= 18;
  }
  static bool IsSenior(Person p)
  {
   return p.Age >= 65;
  }
//---------------------------------------------------
  public class Employees : Person
  {
   public string JobTitle { get; private set; }
   public int EmployeeID { get; private set; }

   // Derived class constructor
   public Employees(string name, int age, string jobTitle, int employeeID)
    : base(name, age) // Calling the base class constructor
   {
    JobTitle = jobTitle;
    EmployeeID = employeeID;
    Console.WriteLine("Employee constructor called");
   }

   public void DisplayEmployeeInfo()
   {
    DisplayPersonInfo(); // Call method from base class
    Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
   }
  }
  //SEALED WILL NOT ALLOW THIS CLASS TO BE INHERITED
  public sealed class Manager : Employees
  {   
   public int TeamSize { get; private set; }

   public Manager(string name, int age, string jobTitle,
    int employeeID, int teamSize)
    : base(name, age, jobTitle, employeeID)
   {
    TeamSize = teamSize;
   }

   public void DisplayManagerInfo()
   {
    DisplayEmployeeInfo(); // Call method from base class
    Console.WriteLine($"Team Size: {TeamSize}");
   }
  }
 }
}