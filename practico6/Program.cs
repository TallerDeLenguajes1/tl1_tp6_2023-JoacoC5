// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("valor de a: " + a);
Console.WriteLine("valor de b: " + b);

int x;
bool control = int.TryParse(Console.ReadLine(), out x);

int resto = 1, aux = x, i = 0;
double invertido = 0;

if (control)
{
    if (x > 0)
    {
        while (aux > 0)
        {
            aux = aux / 10;
            i++;
        }

        while (x > 0)
        {
            resto = x % 10;
            x = x / 10;
            invertido = invertido + (resto * (Math.Pow(10, i - 1)));
            i--;
        }
    }
    Console.WriteLine(invertido);
}
else
{
    Console.WriteLine("No se ingreso un numero");
}