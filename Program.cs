using System;
using System.Linq;

namespace ReversedStrings
{
    public static class Kata
    {
        public static string Solution(string str)
        {
            // throw new NotImplementedException("TODO: Kata.Solution(string) => string");
            return string.Join("", str.Reverse().ToArray());
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to C#");

            Console.WriteLine(Kata.Solution("dom"));
        }
    }
}
