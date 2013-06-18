using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Git! You're wonderful!");
            Console.WriteLine("*** You have been modified for the better ***");
            Console.WriteLine("\nYour fortune for today: {0}", GetFortune());
            Console.ReadKey();
        }

        public static string GetFortune()
        {
            Random rnd = new Random();
            int whichFortune = rnd.Next(1, 4);
            string fortune =  "No fortune for you!";
            switch (whichFortune)
            {
                case 1: fortune = "You will meet a tall, dark, stranger. When you do, RUN."; break;
                case 2: fortune = "You are still hungry. Order more Chinese food."; break;
                case 3: fortune = "The only danger is your own stupidity."; break;
                default: break;
            }
            return fortune;
        }
    }
}
