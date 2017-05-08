using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public char[,] gb = new char[5, 6]; // Initiates 2D array of type char 

        /// <summary>
        /// Contructor initializes all items within the array to draw the board and empty it
        /// </summary>
        public Board()
        {
            gb[0, 0] = '1';
            gb[0, 2] = '|';
            gb[0, 4] = '|';
            gb[1, 1] = '-';
            gb[1, 2] = '-';
            gb[1, 3] = '-';
            gb[1, 4] = '-';
            gb[1, 5] = '-';
            gb[2, 0] = '2';
            gb[2, 2] = '|';
            gb[2, 4] = '|';
            gb[3, 1] = '-';
            gb[3, 2] = '-';
            gb[3, 3] = '-';
            gb[3, 4] = '-';
            gb[3, 5] = '-';
            gb[4, 0] = '3';
            gb[4, 2] = '|';
            gb[4, 4] = '|';
        }

        public void DisplayBoard()
        {
            Console.Clear(); // Clears the screen so that each time board is displayed, it looks as if the console
                                // remains static
            
            // initiates 2 variables to hold the row and column length of the 2D array
            int rowLength = this.gb.GetLength(0); 
            int colLength = this.gb.GetLength(1);

            Console.WriteLine("  1   2   3"); // The "X" coordinates

            // For loop that prints the 2D array as a matrix in order to display the board
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", this.gb[i, j]));
                }
                Console.WriteLine();
            }
            Console.Write("\n");
        }
    }
}
