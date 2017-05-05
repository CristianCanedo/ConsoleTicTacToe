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
        public static bool pOneWins = false;
        public static bool pTwoWins = false;
        public static bool isDraw = false;

        public void StartTurns()
        {
            PlayerOneTurn();
            PlayerTwoTurn();

            if (pOneWins)
            {
                Console.WriteLine("Player {0} wins!\n", p.PlayerOne);
                Console.ReadLine();
            }
            else if (pTwoWins)
            {
                Console.WriteLine("Player {0} wins!\n", p.PlayerTwo);
                Console.ReadLine();
            }
            else if (isDraw)
            {
                Console.WriteLine("Game is a draw!\n");
                Console.ReadLine();
            }


        }

        public void PlayerOneTurn()
        {
            if (pTwoWins == false && pOneWins == false && isDraw == false)
            {
                DisplayBoard();
                Console.WriteLine("Player {0} turn.", this.p.PlayerOne);
                Console.Write("Enter X Coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter Y Coordinate: ");
                int y = int.Parse(Console.ReadLine());
                CheckInputOne(x, y);
            }
        }

        public void PlayerTwoTurn()
        {

            if (pTwoWins == false && pOneWins == false && isDraw == false)
            {
                base.DisplayBoard();
                Console.WriteLine("Player {0} turn.", p.PlayerTwo);
                Console.Write("Enter X Coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter Y Coordinate: ");
                int y = int.Parse(Console.ReadLine());
                CheckInputTwo(x, y);
            }
        }

        public void CheckInputOne(int x, int y)
        {
            switch (x)
            {
                case 1:
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
                case 1:
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

        public void CheckWinner()
        {
            CheckDiagonal();
            CheckHorizontal();
            CheckVertical();
        }

        private void CheckDiagonal()
        {
            if (gb.GetValue(0, 1) is 'X' && gb.GetValue(2, 3) is 'X' && gb.GetValue(4, 5) is 'X'
                         || gb.GetValue(4, 1) is 'X' && gb.GetValue(2, 3) is 'X' && gb.GetValue(0, 5) is 'X') { pOneWins = true; } // Player One Wins!

            else if (gb.GetValue(0, 1) is 'O' && gb.GetValue(2, 3) is 'O' && gb.GetValue(4, 5) is 'O'
                         || gb.GetValue(4, 1) is 'O' && gb.GetValue(2, 3) is 'O' && gb.GetValue(0, 5) is 'O') { pTwoWins = true; } // Player Two Wins!

            else if (gb[0,1] != '\0' && gb[2,3] != '\0' && gb[4, 5] != '\0' && gb[4, 1] != '\0' && 
                            gb[0, 5] != '\0' && gb[0,3] != '\0' && gb[2,5] != '\0' && gb[4,3] != '\0' && gb[2, 1] != '\0') { isDraw = true; } // Game is a draw!

        }

        private void CheckHorizontal()
        {
            if (gb.GetValue(0, 1) is 'X' && gb.GetValue(0, 3) is 'X' && gb.GetValue(0, 5) is 'X'
                        || gb.GetValue(2, 1) is 'X' && gb.GetValue(2, 3) is 'X' && gb.GetValue(2, 5) is 'X'
                                || gb.GetValue(4, 1) is 'X' && gb.GetValue(4, 3) is 'X' && gb.GetValue(4, 5) is 'X') { pOneWins = true; } // Player One wins!

            else if (gb.GetValue(0, 1) is 'O' && gb.GetValue(0, 3) is 'O' && gb.GetValue(0, 5) is 'O'
                        || gb.GetValue(2, 1) is 'O' && gb.GetValue(2, 3) is 'O' && gb.GetValue(2, 5) is 'O'
                                || gb.GetValue(4, 1) is 'O' && gb.GetValue(4, 3) is 'O' && gb.GetValue(4, 5) is 'O') { pTwoWins = true; } // Player Two wins!

            else if (gb[0,1] != '\0' && gb[0, 3] != '\0' && gb[0, 5] != '\0' && gb[2,1] != '\0' &&
                            gb[2,3] != '\0' && gb[2,5] != '\0' && gb[4,1] != '\0' && gb[4,3] != '\0' && gb[4,5] != '\0') { isDraw = true; } // Game is a draw!
        }

        private void CheckVertical()
        {
            if (gb.GetValue(0, 1) is 'X' && gb.GetValue(2, 1) is 'X' && gb.GetValue(4, 1) is 'X' 
                         || gb.GetValue(0, 3) is 'X' && gb.GetValue(2, 3) is 'X' && gb.GetValue(4, 3) is 'X'
                                 || gb.GetValue(0, 5) is 'X' && gb.GetValue(2, 5) is 'X' && gb.GetValue(4, 5) is 'X') { pOneWins = true; } // Player One Wins!

            else if (gb.GetValue(0, 1) is 'O' && gb.GetValue(2, 1) is 'O' && gb.GetValue(4, 1) is 'O'
                         || gb.GetValue(0, 3) is 'O' && gb.GetValue(2, 3) is 'O' && gb.GetValue(4, 3) is 'O'
                                 || gb.GetValue(0, 5) is 'O' && gb.GetValue(2, 5) is 'O' && gb.GetValue(4, 5) is 'O') { pTwoWins = true; } // Player Two Wins!

            else if (gb[0, 1] != '\0' && gb[2, 1] != '\0' && gb[4, 1] != '\0' && gb[0, 3] != '\0' &&
                            gb[2, 3] != '\0' && gb[4, 3] != '\0' && gb[0, 5] != '\0' && gb[2, 5] != '\0' && gb[4, 5] != '\0') { isDraw = true; } // Game is a draw!
        }
    }
}