using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
       /// private static object program;

        public static int triArea(int b, int h)
        {
            return (b * h);

        }

        public static bool Reverse (bool boolean)
        {
            return  ! boolean;
        }
        static void Main(string[] args)
        {
            int area = Program.triArea(5, 6);

            bool answer = Program.Reverse(false);
            Console.WriteLine(answer);
            Console.WriteLine(area);
            Console.ReadLine();
        }

    }
}
