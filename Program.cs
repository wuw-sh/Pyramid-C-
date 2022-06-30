using System;
namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            void pyramid()
            {
                Console.WriteLine("\ninput pyramid size: ");
                int size = int.Parse(Console.ReadLine());
                int num = size, Space, Number;
                Console.WriteLine("\nPrint pyramid");
                for (int i = 1; i <= num; i++)
                {
                    for (Space = 1; Space <= (num - i); Space++)
                        Console.Write(" ");
                    for (Number = 1; Number <= i; Number++)
                        Console.Write("*");
                    for (Number = (i - 1); Number >= 1; Number--)
                        Console.Write("*");
                    Console.WriteLine();
                }
                pyramid();
            }
            pyramid();
            Console.ReadLine();
        }
    }
}