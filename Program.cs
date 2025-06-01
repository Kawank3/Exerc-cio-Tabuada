Console.Write("Digite um número para ver sua tabuada: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"\nTabuada do número: {numero}\n");

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}