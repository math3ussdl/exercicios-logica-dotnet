// See https://aka.ms/new-console-template for more information

Console.Write("Digite o código da primeira peça: ");
Console.ReadLine();

Console.Write("Quantas peças são? ");
var piece1Quantity = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual o valor unitário desta peça? R$");
var piece1Value = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o código da segunda peça: ");
Console.ReadLine();

Console.Write("Quantas peças são? ");
var piece2Quantity = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual o valor unitário desta peça? R$");
var piece2Value = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("-----------------------------------------");
Console.WriteLine($"Valor a pagar: R${piece1Value * piece1Quantity + piece2Value * piece2Quantity}");
