using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessage;
            string userInput;

            Console.WriteLine("Введите сообщение");
            userInput = Console.ReadLine();
            Console.WriteLine("Введите количество повторов");
            numberOfMessage = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfMessage; i++)
            {
                Console.WriteLine(userInput);
            }
        }
    }
}