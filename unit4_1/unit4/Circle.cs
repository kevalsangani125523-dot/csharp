using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit4
{
    internal class Circle
    {
        int r;
        double area;

        public void Getdata()
        {
            Console.WriteLine("Enter Radius");
            r = int.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            area = 3.14 * r * r;
        }
        public void Display()
        {
            Console.WriteLine("Aera :- " + area);
        }
    }
}