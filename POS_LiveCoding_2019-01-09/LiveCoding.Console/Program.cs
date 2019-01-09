using System;

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

            // Beispiel Enumerationen 
            Weekday dayOfTheWeek = Weekday.Sunday;
            System.Console.WriteLine((int)dayOfTheWeek);

            Weekday anotherDayOfTheWeek = Enum.Parse<Weekday>("Sunday");
            System.Console.WriteLine(anotherDayOfTheWeek);
        }
    }
}
