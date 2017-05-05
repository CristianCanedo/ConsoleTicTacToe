using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!\n");
            Turns t = new Turns();
            Board b = new Board();
            b.DisplayBoard();
            t.StartTurns();

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }
    }
}