// See https://aka.ms/new-console-template for more information

const string correctPassword = "2002";
var validPassword = false;

do
{
	Console.Write("Senha: ");
	var input = Console.ReadLine();

	if (input != correctPassword)
	{
		Console.WriteLine("Senha inválida!");
	}
	else
	{
		validPassword = true;
		Console.WriteLine("Acesso permitido!");
	}
}
while (!validPassword);
