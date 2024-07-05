namespace MyQuizzApp;

public class Quizz
{
    private Question[] _questions;
    private int _score;

    public Quizz(Question[] questions) //the array will be run in another class
    {
        this._questions = questions;
        _score = 0;
    }

    public void StartQuizz()
    {
        Console.WriteLine("Welcome to the Quiz!");
        int questionNumber = 1; // Display which question we are at.
        foreach (Question question in _questions)
        {
            Console.WriteLine($"Question {questionNumber}:");
            DisplayQuestion(question);
            int userChoice = GetUserChoice();
            if (question.isCorrectAnswer(userChoice))
            {
                _score++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
            }
        }
        DisplayResults();
    }

    private void DisplayResults()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Results                                 ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        
        Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");

        double percentage = (double)_score / _questions.Length;
        if (percentage >= 0.6)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Excellent work");
        }
    }

    private void DisplayQuestion(Question question) //should be private. (Made public for testing)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Question                                ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine(question.QuestionText); //taking advantage of the property
        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("   "); //create fake indentation
            Console.Write(i+1); //Question number with different colour
            Console.ResetColor(); //makes text normal again
            Console.WriteLine($". {question.Answers[i]}");
        }
    }

    private int GetUserChoice()
    {
        Console.Write("Your answer (number): ");
        string input = Console.ReadLine();
        int choice = 0;
        while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid input.\n Please enter a number between 1 and 4: ");
            input = Console.ReadLine();
        }
        return choice -1; //Decrementing the user choice to fit [0,1,2,3]
    }
}