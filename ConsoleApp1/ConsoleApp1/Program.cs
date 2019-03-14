using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter a value");
            a = int.Parse(Console.ReadLine());


            Console.WriteLine(" enter a value ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("n/t10*n/t100*n/t/t1000*n");
            Console.WriteLine("-/t----/t/t----/t/t-------");


            Console.WriteLine(">>>>for<<<<");
            for (int i = a; i <= b; i++)

            {
                Console.WriteLine($"{i}\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");
            }
            Console.WriteLine(">>>>while<<<<");
            int j = a;
            while (j <= b)
            {
                Console.WriteLine($"(J)\t{j * 10}\t\t{j * 100}\t\t{j * 1000}");
                j++;
            }

            int k = a;

            {
                Console.WriteLine($"(k)\t{k * 10}\t\t{k * 100}\t\t{k * 1000}");
                k++;


            } while (k <= b) ;

            Console.ReadLine();


        }
    }
}
