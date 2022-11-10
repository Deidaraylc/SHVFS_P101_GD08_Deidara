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
                string GetRandom(string[] arr)
                {
                    Random ran = new Random();
                    int n = ran.Next(arr.Length - 1);
                    return arr[n];
                }

                string[] arr = { "A", "B" };

            }
                 
           
        }

    }
}



