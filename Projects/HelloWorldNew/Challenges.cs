namespace HelloWorld;


public class Challenges
{
    public static void RandomNumberGuesser()
    {
        //create instance of random class
        Random random = new Random();
        int randomNumber = random.Next(1, 16);
        // Console.WriteLine(randomNumber); debug line
        Console.WriteLine("Please guess a number between 1 and 15");
        int lives = 2;
        int guess = int.Parse(Console.ReadLine());
        bool won = false;
        while (guess > 15 || guess < 0) 
        {
            Console.WriteLine("Please input another number between 1 and 15");
            guess = int.Parse(Console.ReadLine());
        }
        //Stops at 0 lives, but does not give victory screen if guessed at last try.
        while (lives >= 1 && !won) 
        {
            if (guess != randomNumber )
            {
                Console.WriteLine("Nice try, try another number! \n");
                Console.WriteLine("Lives: " +lives);
                Console.WriteLine(guess > randomNumber ? "Try a little lower!\n" : "Try a little higher!\n");
                --lives;
                guess = int.Parse(Console.ReadLine());
                while (guess > 15 || guess < 0)
                {
                    Console.WriteLine("Please input a number between 1 and 15");
                    guess = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                won = true;
                Console.WriteLine("You got it right!");
            }
        }
        if (lives == 0 && won)
        {
            Console.WriteLine("You'll gettem next time, champ.");
            Console.WriteLine("The answer was " + randomNumber);
        }
    }
    public static void StringMethods()
    {
        string genericString;
        string toSearch;
        int index;
        Console.WriteLine("Enter a string here: ");
        genericString = Console.ReadLine();
        Console.WriteLine("Enter the character to search: ");
        toSearch = Console.ReadLine();

        index = genericString.IndexOf(toSearch);

        Console.WriteLine("The index of said character is: " + index);

        string firstName;
        string lastName;
        string fullName;
         
        Console.WriteLine("Enter your first name:");
        firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        lastName = Console.ReadLine();
        fullName = (firstName + " " + lastName);
        Console.WriteLine(fullName);
        Console.Read();
    }
    
    public static void MyArrayTraining()
    { 
        //Arrays

        int[] myIntArray = new int[5]; //predefined amount, can't be changed
        myIntArray[0] = 15; //assigned index 0 as 15. [0][1][2][3][4] = [5][0][0][0][0]
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please input a number for position {0}.", i+1);
            myIntArray[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int average = 0;
        Console.WriteLine("The final array is as following: ");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(myIntArray[i]);
            sum += myIntArray[i];
        }
        average = sum / 5;

        Console.WriteLine("The total sum is {0} and the average {1}.", sum, average);
    }
    public static void StringConcatenation()
    {
        string myName;
        Console.Write("Please enter your name and press enter: ");
        myName = Console.ReadLine();
        string inputToUpper = myName.ToUpper();
        string inputToLower = myName.ToLower();
        string inputNoWhitespace = myName.Trim();
        var inputSubString = myName.Substring(0,2);


        Console.WriteLine("Solutions:{0} \n{1} \n{2} \n{3}", inputToUpper, inputToLower, inputNoWhitespace, inputSubString);

        //Console.WriteLine("solutions: " + inputToUpper + "\n" + inputToLower + "\n" + inputNoWhitespace + "\n" + inputSubString);

    }

    public static void GreetFriend()
    {
        Console.WriteLine("Please input the name of the friend you would like to greet.");
        string friendName = Console.ReadLine();
        Console.WriteLine("My bestest friend is: " + friendName);
    }
    
    public static void UnaryOperators()
    {
        int num1 = 5;
        int num2 = 3;
        int num3;
        // - as a multiplicator of "-1"
        num3 = -num1;
        Console.WriteLine("num3 is {0}", num3);
        
        // ! as a negator for bool
        bool isSunny = true;
        Console.WriteLine("is it sunny? {0}", !isSunny);
        
        Console.WriteLine(" 5 divide by 3 is: " + num1 / num2);
        Console.WriteLine("The remainder of previous calculation is: " + num1 % num2);
        
        //increment operators
        Console.WriteLine("num1 = " + ++num1); //Pre increment
        Console.WriteLine("num1 = " + num1);
        num1++; // Post increment
        Console.WriteLine("num1 plus one is: {0}", num1);
        Console.WriteLine("num1 minus one is: {0}", --num1);
       
    }
}