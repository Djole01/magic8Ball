using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{

    /// <summary>     
    /// Entry point for magic 8 bll program, by Djordje
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor defualt = Console.ForegroundColor;
            ConsoleColor defaultBackground = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Magic 8 ball program made by Djordje");
            Console.ForegroundColor = defualt;
            Console.BackgroundColor = defaultBackground;
            string[] answers = new string[] { "Yes!", "No!", "Maybe!", "Probably", "Most likely not" };
            Random r = new Random();


            while (true)
            {
            Console.WriteLine(" ");
            Console.WriteLine("Ask a yes/no question! ");
            string question = Console.ReadLine();
                Console.WriteLine(answers[r.Next(0,5)]);

            }



        }
    }
}
