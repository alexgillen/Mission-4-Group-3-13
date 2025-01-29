namespace Mission_4_Group_3_13
{
    //This file will be the supporting class

    //    The “Driver” class (the Program.cs class with the main method where the program begins)
    //    will:
    //• Welcome the user to the game
    //• Create a game board array to store the players’ choices
    //• Ask each player in turn for their choice and update the game board array
    //• Print the board by calling the method in the supporting class
    //• Check for a winner by calling the method in the supporting class, and notify the players
    // when a win has occurred and which player won the game

    //The supporting class (with whichever name you choose) will:
    //• Receive the “board” array from the driver class
    //• Contain a method that prints the board based on the information passed to it
    //• Contain a method that receives the game board array as input and returns if there is a
    // winner and who it was

    internal class Class1
    {
        public void PrintBoard(char[] ga)
        {
            bool gameOver = false;

            // Printing the board:
            Console.WriteLine($"{ga[0]} {ga[1]} {ga[2]}");
            Console.WriteLine($"{ga[3]} {ga[4]} {ga[5]}");
            Console.WriteLine($"{ga[6]} {ga[7]} {ga[8]}");

            if (ga[0] == ga[1] && ga[1] == ga[2])
            {

            }
            else if (ga[3] == ga[4] && ga[4] == ga[5])
            {

            }
            else if (ga[6] == ga[7] && ga[7] == ga[8])
            {

            }
            else if (ga[0] == ga[3] && ga[3] == ga[6])
            {

            }
            else if (ga[1] == ga[4] && ga[4] == ga[7])
            {

            }
            else if (ga[2] == ga[5] && ga[5] == ga[8])
            {

            }
            else if (ga[0] == ga[4] && ga[4] == ga[8])
            {

            }
            else if (ga[6] == ga[4] && ga[4] == ga[2])
            {

            }

            array.contains = [1,2,3]



            else
            {
                for (int i = 0; i < ga.Length; i++)
                { 
                    if (ga[i] != 'X' || ga[i] != 'O')
                    {
                        //Leave the loop because there isn't a tie
                        Console.WriteLine("It's not a tie");
                    }
                }

                // For sure a tie
                Console.WriteLine("It's a tie");
            }
        }

        //- - -
        //- - -
        //- - -

            //0 1 2
            //3 4 5
            //6 7 8 
    }
}
