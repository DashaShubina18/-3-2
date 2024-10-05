using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3_завдання_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1.25;
            double e = Math.Pow(10, -6);
            double sum = 0;
            double term;
            double fault = 1;
            int n = 1;
            Console.OutputEncoding=Encoding.UTF8;
            do
            {
                term = Math.Pow(n, (Math.Log(n)) / (Math.Pow((x + Math.Log(n)), n)));
                sum += term;
                fault = Math.Abs(term/sum);
                n++;
            } while (fault>e);
            Console.WriteLine($"Номер ітерації = {n}");
            Console.WriteLine($"Величина поточного ряду: {term}");
            Console.WriteLine($"Накопичена сума S2: {sum} ");
            Console.WriteLine($"Досягнута на поточній ітерації похибка: {fault}");
            Console.ReadKey();


        }
    }
}
