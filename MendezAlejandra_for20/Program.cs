// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pedir una cantidad N de números e indicar cuántos son positivos.");

Console.Write("¿Cuántos números?: ");
int n = int.Parse(Console.ReadLine());
int positivos = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese número: ");
    int num = int.Parse(Console.ReadLine());

    if (num > 0)
        positivos++;
}

Console.WriteLine("Positivos: " + positivos);
