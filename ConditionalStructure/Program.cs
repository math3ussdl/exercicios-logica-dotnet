// See https://aka.ms/new-console-template for more information

Console.Write("Informe o código do produto: ");
var code = Console.ReadLine();

Console.Write("Agora informe quantos produtos você quer: ");
var quantity = Convert.ToInt32(Console.ReadLine());

var result = code switch
{
	"1" => 4.00 * quantity,
	"2" => 4.50 * quantity,
	"3" => 5.00 * quantity,
	"4" => 2.00 * quantity,
	"5" => 1.50 * quantity,
	_ => throw new Exception("Código inválido!")
};

Console.WriteLine($"Total: R$ {result:N2}");
