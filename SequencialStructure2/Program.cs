// See https://aka.ms/new-console-template for more information

const double pi = 3.14159;

Console.WriteLine("Digite o raio de um círculo qualquer: ");
var radius = Convert.ToDouble(Console.ReadLine());

var area = pi * (radius * radius);

Console.WriteLine($"A={area:N4}");
