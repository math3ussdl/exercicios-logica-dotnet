// See https://aka.ms/new-console-template for more information

const int intervalStart = 10;
const int intervalEnd = 20;

var inputs = new List<int>();
var outputs = new List<int>();

Console.Write("Informe a quantidade de numeros que vc vai adicionar: ");
var quantityOfNumbers = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("------------------------------------------");

for (var i = 0; i < quantityOfNumbers; i++)
{
	Console.Write("Digite o número: ");
	var number = Convert.ToInt32(Console.ReadLine());
	if (number is >= intervalStart and <= intervalEnd)
	{
		inputs.Add(number);
	}
	else
	{
		outputs.Add(number);
	}
}

Console.WriteLine($"{inputs.Count} in");
Console.WriteLine($"{outputs.Count} out");
