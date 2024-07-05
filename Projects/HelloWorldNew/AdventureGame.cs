using System.ComponentModel;

namespace HelloWorld;

public class AdventureGame
{
    public static void Play()
    {
        bool gameContinues = true;
        Console.WriteLine("Welcome to the Adventure Game!" +"\n"+ "Enter your Character's name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine("Please choose your character class. (Warrior, Wizard, Mage, Archer, Thief)");
        string playerClass = Console.ReadLine();
        
        Console.WriteLine($"You, {playerName}, the {playerClass}, find yourself at the edge of a dark forest.");
        Console.WriteLine("Do you enter the forest? (enter/stay)"); 
        string choice1 = Console.ReadLine();

        if (choice1.ToLower().Trim() == "enter")
        {
                Console.WriteLine("You enter the forest.");
        }
        else
        {
            Console.WriteLine("The pressure of that dark forest breaks your will and you decided to avoid this adventure.");
            gameContinues = false;
        }

        while (gameContinues)
        {
            Console.WriteLine("You come to a fork in the road. Go left or right?");
            string choice2 = Console.ReadLine();
            if (choice2.ToLower().Trim() == "left")
            {
                Console.WriteLine("You find a treasure chest filled with riches and fulfillment");
                gameContinues = false;
            }
            else
            {
                Console.WriteLine("You encounter a wild beast, eager to defend it's territory!");
                Console.WriteLine("Fight or flee? (fight/flee)");
                string choice3 = Console.ReadLine();
                if (choice3.ToLower().Trim() == "fight")
                {
                    Random random = new Random();
                    int luck = random.Next(1, 20);
                    if (luck > 12)
                    {
                        Console.WriteLine("You manage to land a blow on the wild beast and make it leave in fear. You are safe.");
                    }
                    else
                    {
                        Console.WriteLine("Your lack of experience causes your doom and you are felled by the wild beast in the middle of a forest where no one will know your name.");
                        gameContinues = false;
                    }
                }
            }
        }
        Console.WriteLine("Game Over. \nThank you for playing the Adventure Game.");
    }
} 

