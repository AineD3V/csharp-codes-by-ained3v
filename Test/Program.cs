using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
        	double RUBTOUSD = 74.72;
        	double UAHTOUSD = 27.76;
        	double EURTOUSD = 0.83;
        	double TENGETOUSD = 420.50;
        	double USD;

        	Console.WriteLine("Введите число долларов которую хотите выcчитать: ");

        	USD = double.Parse(Console.ReadLine());

        	Console.WriteLine(USD + " Долларов в рублях = " + USD * RUBTOUSD + " рублей");
        	Console.WriteLine(USD + " Долларов в гривнах = " + USD * UAHTOUSD + " гривен");
        	Console.WriteLine(USD + " Долларов в евро = " + USD * EURTOUSD + " евро");
        	Console.WriteLine(USD + " Долларов в тенге = " + USD * TENGETOUSD + " тенге");

        }
    }
}