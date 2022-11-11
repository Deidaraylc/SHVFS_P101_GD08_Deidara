using System.Diagnostics.Tracing;

namespace SHVFS_P101_GD08_Deidara
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("hey, what your name");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("ok,Let's guess the word together.");

            {
                int i = 1;
                string answer;
                string[] a = { "A", "B" };
                Random rand = new Random();
                int name = rand.Next(a.Length);
                Console.WriteLine("Welcome the game, what's your name");
                Console.ReadLine();
                Console.WriteLine(" guess!");
                Console.WriteLine("The words are A, B");
                answer = Console.ReadLine();
                do
                {
                    if (answer == a[name])
                    {
                        Console.WriteLine("You are right!");
                    }
                    else if (answer != a[name])
                    {
                        Console.WriteLine("Wrong");
                        Console.WriteLine(" Try again");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    i = i + 1;
                } while (answer != a[name]);
                Console.WriteLine("Good !");
                Console.WriteLine($"You finish the game for {i} times.");
                Console.ReadLine();
            }
        }
    }
}