using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1582, 10, 5);
            Console.WriteLine(dateTime.DayOfWeek);

        }
    }
}
