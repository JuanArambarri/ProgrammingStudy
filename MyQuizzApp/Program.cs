namespace MyQuizzApp;

class Program
{
    static void Main(string[] args)
    {
        Question[] questions = new Question[]
        {
            new Question(
                "What is the capital of Germany?",
                new String[] { "Paris", "Berlin", "London", "Madrid" },
                1),
            new Question(
                "What is the population of Japan?",
                new String[]{"140 million", "115 million", "150 million", "125 million"},
                3),
            new Question(
                "How do you say Hello in Japanese?",
                new string[]{"ohayou gozaimasu","Konbanwa","Arigatou gozaimasu","Dou itashimashite"},
                0
                )
        };
        Quizz myQuizz = new Quizz(questions);
        myQuizz.StartQuizz();
        /* Preliminary try to check for answer.
        int choice = int.Parse(Console.ReadLine());
        if(questions[0].isCorrectAnswer(choice)){
        cw "You have guessed right";
        }else{"You have guess wrong";}
        */
    }
}