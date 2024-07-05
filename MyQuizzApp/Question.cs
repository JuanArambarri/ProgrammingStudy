namespace MyQuizzApp;

public class Question
{ 
    public string QuestionText { get; set; }
    public string[] Answers { get; set; }
    public int CorrectAnswerIndex { get; set; } //

    public Question(string questionText, string[] answers, int correctAnswerIndex) //pass questions, answers and check answer
    {
        QuestionText = questionText;
        Answers = answers;
        CorrectAnswerIndex = correctAnswerIndex;
    }

    public bool isCorrectAnswer(int choice)
    {
        return CorrectAnswerIndex == choice;
    }
}