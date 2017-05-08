using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Turns : Board
    {
        Players p = new Players();
        public static bool pOneWins = false; // variable to determine whether or not player one wins
        public static bool pTwoWins = false; // variable to determine whether or not player two wins
        public static bool isDraw = false; // variable to determine whether or not the game is a draw


        // Initiates the player turns and when finished checks each of the bool variables to print
        // the corresponding message to the screen.
        public void StartTurns()
        {
            PlayerOneTurn();
            PlayerTwoTurn();

            if (pOneWins)
            {
                Console.WriteLine("Player {0} wins!", p.PlayerOne);
                Console.ReadLine();
            }
            else if (pTwoWins)
            {
                Console.WriteLine("Player {0} wins!", p.PlayerTwo);
                Console.ReadLine();
            }
            else if (isDraw)
            {
                Console.WriteLine("Game is a draw!");
                Console.ReadLine();
            }


        }


        /// <summary>
        /// PlayerOneTurn() & PlayerTwoTurn() only run if all bool variables are set to false.
        /// Only then can the player enter the X and Y coordinates where he or she chooses to place a piece on the board.
        /// </summary>
        public void PlayerOneTurn()
        {
            if (pTwoWins == false && pOneWins == false && isDraw == false)
            {
                Console.WriteLine("Player {0} turn.", this.p.PlayerOne);
                Console.Write("Enter X Coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter Y Coordinate: ");
                int y = int.Parse(Console.ReadLine());
                CheckInputOne(x, y); // Calls the CheckInputOne method for PlayerOne
            }
        }
        public void PlayerTwoTurn()
        {

            if (pTwoWins == false && pOneWins == false && isDraw == false)
            {
                Console.WriteLine("Player {0} turn.", p.PlayerTwo);
                Console.Write("Enter X Coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter Y Coordinate: ");
                int y = int.Parse(Console.ReadLine());
                CheckInputTwo(x, y); // Calls the CheckInputTwo method for PlayerTwo
            }
        }

        
        /// <summary>
        /// CheckInputOne() & CheckInputTwo() check the users X and Y input and place a piece
        /// on the board if that space is empty, calls the CheckWinner() method, then passes
        /// the turn to the next player by calling their respective player turn methods.
        /// </summary>
        public void CheckInputOne(int x, int y)
        {
            switch (x)
            {
                case 1:// if y == 1-3, AND gb space is empty, assign 'X', if not retry
                    if (y == 1) if (base.gb[0, 1] == '\0') { base.gb[0, 1] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    if (y == 2) if (base.gb[2, 1] == '\0') { base.gb[2, 1] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    if (y == 3) if (base.gb[4, 1] == '\0') { base.gb[4, 1] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    break;
                case 2:
                    if (y == 1) if (base.gb[0, 3] == '\0') { base.gb[0, 3] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    if (y == 2) if (base.gb[2, 3] == '\0') { base.gb[2, 3] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    if (y == 3) if (base.gb[4, 3] == '\0') { base.gb[4, 3] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    break;

                case 3:
                    if (y == 1) if (base.gb[0, 5] == '\0') { base.gb[0, 5] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    if (y == 2) if (base.gb[2, 5] == '\0') { base.gb[2, 5] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    if (y == 3) if (base.gb[4, 5] == '\0') { base.gb[4, 5] = 'X'; base.DisplayBoard(); CheckWinner(); PlayerTwoTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerOneTurn(); }
                    break;
                default:
                    break;
            }
        }

        public void CheckInputTwo(int x, int y)
        {
            switch (x)
            {
                case 1:// if y == 1-3, AND gb space is empty, assign 'O', if not retry
                    if (y == 1) if (base.gb[0, 1] == '\0') { base.gb[0, 1] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    if (y == 2) if (base.gb[2, 1] == '\0') { base.gb[2, 1] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    if (y == 3) if (base.gb[4, 1] == '\0') { base.gb[4, 1] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    break;
                case 2:
                    if (y == 1) if (base.gb[0, 3] == '\0') { base.gb[0, 3] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    if (y == 2) if (base.gb[2, 3] == '\0') { base.gb[2, 3] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    if (y == 3) if (base.gb[4, 3] == '\0') { base.gb[4, 3] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    break;
                case 3:
                    if (y == 1) if (base.gb[0, 5] == '\0') { base.gb[0, 5] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    if (y == 2) if (base.gb[2, 5] == '\0') { base.gb[2, 5] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    if (y == 3) if (base.gb[4, 5] == '\0') { base.gb[4, 5] = 'O'; base.DisplayBoard(); CheckWinner(); PlayerOneTurn(); } else { Console.WriteLine("Cannot play that space. Press enter to choose another."); Console.ReadLine(); PlayerTwoTurn(); }
                    break;
                default:
                    break;
            }

        }

        // CheckWinner() method steps through each Diagonal, Horizontal, and Vertical method to check the 2D array
        public void CheckWinner()
        {
            CheckDiagonal();
            CheckHorizontal();
            CheckVertical();
        }

        // Checks the diagonal array indexes to make sure they all equal either an 'X' or 'O' and 
        // assigns "true" to the respective player. Else if all spaces are filled and none match,
        // isDraw will equal true.
        private void CheckDiagonal()
        {
            if (gb[0, 1] == 'X' && gb[2, 3] == 'X' && gb[4, 5] == 'X'|| gb[4, 1] == 'X' && gb[2, 3] == 'X' && gb[0, 5] == 'X') { pOneWins = true; } // Player One Wins!

            else if (gb[0, 1] == 'O' && gb[2, 3] == 'O' && gb[4, 5] == 'O' || gb[4, 1] == 'O' && gb[2, 3] == 'O' && gb[0, 5] == 'O') { pTwoWins = true; } // Player Two Wins!

            else if (gb[0,1] != '\0' && gb[2,3] != '\0' && gb[4, 5] != '\0' && gb[4, 1] != '\0' && 
                            gb[0, 5] != '\0' && gb[0,3] != '\0' && gb[2,5] != '\0' && gb[4,3] != '\0' && gb[2, 1] != '\0') { isDraw = true; } // Game is a draw! 

        }

        private void CheckHorizontal()
        {
            if (gb[0, 1] == 'X' && gb[0, 3] == 'X' && gb[0, 5] == 'X'
                        || gb[2, 1] == 'X' && gb[2, 3] == 'X' && gb[2, 5] == 'X'
                                || gb[4, 1] == 'X' && gb[4, 3] == 'X' && gb[4, 5] == 'X') { pOneWins = true; } // Player One wins!

            else if (gb[0, 1] == 'O' && gb[0, 3] == 'O' && gb[0, 5] == 'O'
                        || gb[2, 1] == 'O' && gb[2, 3] == 'O' && gb[2, 5] == 'O'
                                || gb[4, 1] == 'O' && gb[4, 3] == 'O' && gb[4, 5] == 'O') { pTwoWins = true; } // Player Two wins!

            else if (gb[0, 1] != '\0' && gb[0, 3] != '\0' && gb[0, 5] != '\0' && gb[2, 1] != '\0' &&
                            gb[2, 3] != '\0' && gb[2, 5] != '\0' && gb[4, 1] != '\0' && gb[4, 3] != '\0' && gb[4, 5] != '\0') { isDraw = true; } // Game is a draw! 
        }

        private void CheckVertical()
        {
            if (gb[0, 1] == 'X' && gb[2, 1] == 'X' && gb[4, 1] == 'X'
                        || gb[0, 3] == 'X' && gb[2, 3] == 'X' && gb[4, 3] == 'X'
                                || gb[0, 5] == 'X' && gb[2, 5] == 'X' && gb[4, 5] == 'X') { pOneWins = true; } // Player One Wins!

            else if (gb[0, 1] == 'O' && gb[2, 1] == 'O' && gb[4, 1] == 'O'
                        || gb[0, 3] == 'O' && gb[2, 3] == 'O' && gb[4, 3] == 'O'
                                || gb[0, 5] == 'O' && gb[2, 5] == 'O' && gb[4, 5] == 'O') { pTwoWins = true; } // Player Two Wins!

            else if (gb[0, 1] != '\0' && gb[0, 3] != '\0' && gb[0, 5] != '\0' && gb[2, 1] != '\0' &&
                            gb[2, 3] != '\0' && gb[2, 5] != '\0' && gb[4, 1] != '\0' && gb[4, 3] != '\0' && gb[4, 5] != '\0') { isDraw = true; } // Game is a draw!
        }
    }
}
