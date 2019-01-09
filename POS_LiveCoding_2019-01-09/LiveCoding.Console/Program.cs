using System;
using System.Runtime.InteropServices;

namespace LiveCoding.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.ForegroundColor = ConsoleColor.DarkRed;

            System.Console.WriteLine($"Das Zeichen 7 ist eine Ziffer: {CharUtils.IsDigit('7')}." );
            System.Console.WriteLine($"Das Zeichen 7 ist eine Ziffer: {'7'.IsDigit()}.");

            System.Console.WriteLine($"Das Zeichen 'd' kommt in 'Donaudampfschifffahrtsgesellschaft' {"Donaudampfschifffahrtsgesellschaft".CountChars('d', ignoreCase: true)} mal vor");


            // Parsen von Enumerationen
            string strOrderTypeFromCsv = "ToPay";
            Task myNewTask = new Task();
            //if(strOrderTypeFromCsv.CompareTo("ToPay"))
            //    myNewTask.Type = OrderType.ToPay;
            // ... oder:
            myNewTask.Type = Enum.Parse<OrderType>(strOrderTypeFromCsv);
            System.Console.WriteLine(myNewTask.Type);
        }
    }
}
