using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitkov_pr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, n_copy, reversed = 0, raz;
            double proc, proc1;
            Console.WriteLine("Введите число n:");
            n = Convert.ToInt32(Console.ReadLine());
            n_copy = n;
            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n /= 10;
            }
            raz = n_copy - reversed;
            Console.Clear();
            raz = Math.Abs(raz);
            proc = ((double)n_copy / (n_copy + raz)) * 100;
            proc1 = ((double)reversed / (reversed + raz)) * 100;
            Console.WriteLine($"reversed(n) больше n на - {proc}%");
            Console.WriteLine();
            Console.WriteLine($"n больше reversed(n) на - {proc1}%");
            return;
        }
    }
}
