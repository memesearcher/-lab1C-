using System;
public class Program
{
	public static void Main(string[] args)
	{

		double rez;
		for (double i = 0; i<15; i+=0.314)
		{   
    		rez = 2 * Math.Sin(i) + Math.Cos(i);
    		Console.WriteLine("При x =");
    		Console.WriteLine(i);
    		Console.WriteLine("Функция равна");
    		Console.WriteLine(rez);
    		Console.WriteLine("\n");
        }
    }
}