namespace HelloWorld;

public class TicTacToeTheGame
{
    
    static char[,] ticTacToeBoard =
    {
        {'O','O','O'}, 
        {'O','O','O'},
        {'O','O','O'}
    };
    
    public static void TicTacToe()
    {
    bool playerOneWin = false;
    bool playerTwoWin = false;
    bool playerTurn = true;
    Console.WriteLine("Starting Tic Tac Toe game. Player one will fill with \"X\", Player two will fill with \"Y\".");
    int moves = 0;
    while (!playerOneWin && !playerTwoWin && moves <= 6)
    {
        if (playerTurn)
        {
            Player1InputTTT();
            playerOneWin = CheckPlayerOneWin();
            playerTurn = false;
            moves++;
        }
        else
        {
            Player2InputTTT();
            playerTwoWin = CheckPlayerTwoWin();
            playerTurn = true;
            moves++;
        }
    }
        
    if (playerOneWin || playerTwoWin)
    {
        if (playerOneWin)
        {
            Console.WriteLine("Player one has won!");
        }

        if (playerTwoWin)
        {
            Console.WriteLine("Player two has won!");
        }
    }
    else
    {
        Console.WriteLine("You have run out of tries.");
        Console.WriteLine("None of you have won, shame on you.");
    }
    DisplayBoard();
    }

    private static void Player1InputTTT()
    {
        bool filled = false;
        while (!filled)
        {
            DisplayBoard();
            Console.WriteLine("Player 1: Please select the row: (0, 1 or 2)");
            int playerRowInput = int.Parse(Console.ReadLine());
            while (playerRowInput is < 0 or > 2)
            {
                Console.WriteLine("Please write a number between 0 and 2");
                playerRowInput = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            int row = playerRowInput;
            Console.WriteLine("Player 1: Please select the column (0,1 or 2)");
            int playerColumnInput = int.Parse(Console.ReadLine());
            while (playerColumnInput<0 || playerColumnInput>2)
            {
                Console.WriteLine("Please write a number between 0 and 2");
                playerColumnInput = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            int column = playerColumnInput;
            if (ticTacToeBoard[row,column] == 'X' || ticTacToeBoard[row, column] == 'Y')
            {
                Console.WriteLine("This space is already filled. Please try again. \n");
                continue;
            }
            ticTacToeBoard[row, column] = 'X';
            filled = true;
            DisplayBoard();
            Console.Clear();
        }
    }
    private static void Player2InputTTT()
    {
        bool filled = false;
        while (!filled)
        {
            DisplayBoard();
            Console.WriteLine("Player 2: Please select the row: (0, 1 or 2)");
            int playerRowInput = int.Parse(Console.ReadLine());
            while (playerRowInput is < 0 or > 2)
            {
                Console.WriteLine("Please write a number between 0 and 2");
                playerRowInput = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            int row = playerRowInput;
            Console.WriteLine("Player 1: Please select the column (0,1 or 2)");
            int playerColumnInput = int.Parse(Console.ReadLine());
            while (playerColumnInput<0 || playerColumnInput>2)
            {
                Console.WriteLine("Please write a number between 0 and 2");
                playerColumnInput = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            int column = playerColumnInput;
            if (ticTacToeBoard[row,column] == 'X' || ticTacToeBoard[row, column] == 'Y')
            {
                Console.WriteLine("This space is already filled. Please try again. \n");
                continue;
            }
            ticTacToeBoard[row, column] = 'Y';
            filled = true;
            DisplayBoard();
            Console.Clear();
        }
    }
    private static bool CheckPlayerOneWin()
    {
        if (ticTacToeBoard[0,0] == 'X' && ticTacToeBoard[0,1] == 'X' && ticTacToeBoard[0,2] == 'X' 
            || ticTacToeBoard[1,0] == 'X' && ticTacToeBoard[1,1] == 'X' && ticTacToeBoard[1,2] == 'X'
            || ticTacToeBoard[2,0] == 'X' && ticTacToeBoard[2,1] == 'X' && ticTacToeBoard[2,2] == 'X'
            || ticTacToeBoard[0,0] == 'X' && ticTacToeBoard[1,1] == 'X' && ticTacToeBoard[2,2] == 'X'
            || ticTacToeBoard[0,2] == 'X' && ticTacToeBoard[1,1] == 'X' && ticTacToeBoard[2,0] == 'X'
            || ticTacToeBoard[0,0] == 'X' && ticTacToeBoard[1,0] == 'X' && ticTacToeBoard[2,0] == 'X'
            || ticTacToeBoard[0,1] == 'X' && ticTacToeBoard[1,1] == 'X' && ticTacToeBoard[2,1] == 'X'
            || ticTacToeBoard[0,2] == 'X' && ticTacToeBoard[1,2] == 'X' && ticTacToeBoard[2,2] == 'X'
           )
        {
            return true;
        }

        return false;
    }

    private static bool CheckPlayerTwoWin()
    {
        if (ticTacToeBoard[0,0] == 'Y' && ticTacToeBoard[0,1] == 'Y' && ticTacToeBoard[0,2] == 'Y' 
            || ticTacToeBoard[1,0] == 'Y' && ticTacToeBoard[1,1] == 'Y' && ticTacToeBoard[1,2] == 'Y'
            || ticTacToeBoard[2,0] == 'Y' && ticTacToeBoard[2,1] == 'Y' && ticTacToeBoard[2,2] == 'Y'
            || ticTacToeBoard[0,0] == 'Y' && ticTacToeBoard[1,1] == 'Y' && ticTacToeBoard[2,2] == 'Y'
            || ticTacToeBoard[0,2] == 'Y' && ticTacToeBoard[1,1] == 'Y' && ticTacToeBoard[2,0] == 'Y'
            || ticTacToeBoard[0,0] == 'Y' && ticTacToeBoard[1,0] == 'Y' && ticTacToeBoard[2,0] == 'Y'
            || ticTacToeBoard[0,1] == 'Y' && ticTacToeBoard[1,1] == 'Y' && ticTacToeBoard[2,1] == 'Y'
            || ticTacToeBoard[0,2] == 'Y' && ticTacToeBoard[1,2] == 'Y' && ticTacToeBoard[2,2] == 'Y'
           )
        {
            return true;
        }

        return false;
    }
    private static void DisplayBoard()
    {
        for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
        {
            for (int j = 0; j < ticTacToeBoard.GetLength(1); j++)
            {
                Console.Write(ticTacToeBoard[i,j] + " ");
            }

            Console.WriteLine("");
        }
    }
}