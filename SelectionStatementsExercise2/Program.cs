using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("Welcome to Fav Subject");

            String subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I don't prefer math ");
                    break;
                case "science":
                    Console.WriteLine("Science rules");
                    break;
                case "pe":
                case "p.e":
                case "physical education":
                    Console.WriteLine("P.E. is fun");
                    break;
                case "history":
                    Console.WriteLine("History rules");
                    break;
                case "geography":
                    Console.WriteLine("I like to study the world");
                    break;
                default:
                    Console.WriteLine("I like that too");
                    break;

            }

        }
    }
}