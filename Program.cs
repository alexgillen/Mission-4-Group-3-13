using System.Numerics;
using System.Runtime.InteropServices;
using Mission_4_Group_3_13;

Class1 c1 = new Class1();
bool endGame = false;

Console.WriteLine("Welcome to the game");

char[] boardArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

for (int i = 0; i < 11; i++)
{
    if (i < 9)
    {
        endGame = c1.PrintBoard(boardArray);
        if (endGame)
        {
            break;
        }
        Console.WriteLine("Player 1 please enter a number");
        int number1 = Convert.ToInt16(Console.ReadLine());
        
        boardArray[number1 - 1] = 'X';

        endGame = c1.PrintBoard(boardArray);
        if (endGame)
        {
            break;
        }
        Console.WriteLine("Player 2 please enter a number");
        int number2 = Convert.ToInt16(Console.ReadLine());

        boardArray[number2 - 1] = 'O';
        
    }
    else if (i == 9)
    {
        Console.WriteLine("It's a tie! Game over");
    }
    
}
