// See https://aka.ms/new-console-template for more information

Console.Write("Digite o valor de a: ");
var inputA = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de b: ");
var inputB = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de c: ");
var inputC = Convert.ToDouble(Console.ReadLine());

if (inputA == 0)
{
	Console.WriteLine("Impossível calcular");
	Environment.Exit(1);
}

var delta = (inputB * inputB) - 4 * inputA * inputC;

if (delta < 0)
{
	Console.WriteLine("Impossível calcular");
	Environment.Exit(1);
}

var x1 = (-inputB + Math.Sqrt(delta)) / (2 * inputA);
var x2 = (-inputB - Math.Sqrt(delta)) / (2 * inputA);

Console.WriteLine($"X1 = {x1:N5}");
Console.WriteLine($"X2 = {x2:N5}");
