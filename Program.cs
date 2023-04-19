Console.Clear();

double numero, avaliar, resultado;

Console.WriteLine("--- multiplo ---\n");

Console.Write("Digite um numero..........: ");
numero = Int32.Parse(Console.ReadLine()!);

Console.Write("Avaliar se e multiplo por.: ");
avaliar = Int32.Parse(Console.ReadLine()!);

Console.WriteLine();

resultado = numero % avaliar;

if (resultado != 0)
{
    Console.WriteLine($"{numero} não é multiplo de {avaliar}");
}
else
{
    Console.WriteLine($"{numero} é multiplo de {avaliar}");
}
