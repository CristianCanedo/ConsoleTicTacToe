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
            Console.WriteLine("***********************");
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("***********************\n");

            Turns t = new Turns(); // Creates new object of type Turn (initiates new players)
            Board b = new Board(); // Creates new object of type Board (initiates a new clean board)
            b.DisplayBoard(); // Displays board
            t.StartTurns(); // Starts turns from the Turn class

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }
    }
}
