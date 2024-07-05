namespace HelloWorld;

public class QuizzApp
{
    public static void Quizz()
    {
        //Questions & Answers
        int score = 0;
        string question1 = "What is the capital of Germany";
        string answer1 = "Berlin";
        Console.WriteLine(question1);
        if (Console.ReadLine().Trim().ToLower().Equals(answer1.ToLower().Trim()))
        {
            score++;
            Console.WriteLine();
        }else Console.WriteLine("The correct answer is: " +answer1 + "\n");

        string question2 = "What is 2+2";
        string answer2 = "4";
        Console.WriteLine(question2);
        if (Console.ReadLine().Trim().ToLower().Equals(answer2.ToLower().Trim()))
        {
            score++;
            Console.WriteLine();
        }else Console.WriteLine("The correct answer is: " +answer2 + "\n");

        string question3 = "What color do you get by mixing blue and yellow"; 
        string answer3 = "Green";
        Console.WriteLine(question3);
        if (Console.ReadLine().Trim().ToLower().Equals(answer3.ToLower().Trim()))
        {
            score++;
            Console.WriteLine();
        }else Console.WriteLine("The correct answer is: " +answer3 + "\n");
    
        switch (score)
        {
            case 1:
                Console.WriteLine("You only had one right answer, please try again! \n ");
                break;
            case 2:
                Console.WriteLine("You had two right answers, you were almost there! \n");
                break;
            case 3:
                Console.WriteLine("Congratulations! You got all of them right! \n ");
                break;
        }
    }
}