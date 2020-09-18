using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N    N  RRRRR ");
            Console.WriteLine("NN   N  R    R");
            Console.WriteLine("N N  N  RRRRRR");
            Console.WriteLine("N  N N  R    R");
            Console.WriteLine("N   NN  R    R");

            Console.ReadLine();

            string firstName = "Noah";
            string favMovie = "The Matrix";

            Console.WriteLine($"Hello, {firstName.ToLower()}! Your favourite movie is {favMovie.ToLower()} .");

            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE"));

            Console.WriteLine(favMovie);
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
            
            Console.ReadLine();

        }
    }
}
