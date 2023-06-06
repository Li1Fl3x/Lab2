using ConsoleApp13;
using System.Numerics;

Calculator calculator1 = new Calculator(4, 7);
Calculator calculator2 = new Calculator(5, 8);
Calculator calculator3 = calculator1 + calculator2;
Console.WriteLine(calculator3.ToString());
Calculator calculator4 = calculator1 - calculator2;
Console.WriteLine(calculator4.ToString());
Calculator calculator5 = calculator1 * calculator2;
Console.WriteLine(calculator5.ToString());
Calculator calculator6 = calculator1 / calculator2;
Console.WriteLine(calculator6.ToString());
Console.WriteLine(calculator1 == calculator2);
Console.WriteLine(calculator1 != calculator2);