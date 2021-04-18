using System;

namespace ComunicacaoPiralandia
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            char[] arr = n.ToCharArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                System.Console.Write(arr[i]);
            }

        }
    }
}
