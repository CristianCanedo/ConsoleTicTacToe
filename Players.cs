using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TicTacToe
{
    public class Players
    {
        // Declaraing two public string variables for PlayerOne and PlayerTwo
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }

        public Players()
        {
            // Asks user input for PlayerOne and PlayerTwo names
            Console.Write("Choose PlayerOne name: ");
            PlayerOne = Console.ReadLine();
            Console.Write("Choose PlayerTwo name: ");
            PlayerTwo = Console.ReadLine();
        }
    }
}
