using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of Christmas tree (do not less than 3) : ");
            int size = int.Parse(Console.ReadLine());

            if(size < 3)
            {
                Console.WriteLine("do not less than 3.");
                Console.ReadKey();
                return;
            }
            for(int temp = 0 ; temp != 2 ; temp++)
            {
                for (int high = 1 ; high <= size ; high++)
                {
                    for (int space = size ; space >= high ; space--)
                    {
                        Console.Write(" ");
                    }
                    for (int star = 1 ; star <= high ; star++)
                    {
                        Console.Write("*");
                    }
                    for (int star2 = 1 ; star2 < high ; star2++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            for(int temp2 = 1; temp2 <= 2 ; temp2++)
            {
                for (int wood = 0 ; wood <= size-2 ; wood++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("***");
            }
            Console.ReadKey();
        }
    }
}
