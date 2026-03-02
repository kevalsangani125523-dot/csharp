using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit4
{
    internal class Rectangle
    {
        int l, w, area;

        public void Getdata()
        {
            Console.WriteLine("Enter Lenth");
            l = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width");
            w = int.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            area = l * w;
        }
        public void Display()
        {
            Console.WriteLine("Aera :- " + area);
        }
    }
}