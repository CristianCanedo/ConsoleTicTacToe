using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TicTacToe
{
    public class Players
    {

        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }

        public Players()
        {
            Console.Write("Choose PlayerOne name: ");
            PlayerOne = Console.ReadLine();
            Console.Write("Choose PlayerTwo name: ");
            PlayerTwo = Console.ReadLine();
        }
    }
}