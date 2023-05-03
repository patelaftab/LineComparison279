using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison279
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Problem");
            Line line = new Line(1, 2, 5, 4);
            line.Length();
            Console.ReadLine();
        }
    }
}
