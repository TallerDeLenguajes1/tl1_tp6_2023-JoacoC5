// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----Mejoras de Calculadora-----");
Console.WriteLine("Ingrese un numero a analizar: ");

float x;
bool controlUno = float.TryParse(Console.ReadLine(), out x);

if (controlUno)
{
    float absoluto = Math.Abs(x);
    double cuadrado = Math.Pow(x, 2);
    double raiz = Math.Sqrt(x);
    double seno = Math.Sin(x);
    double coseno = Math.Cos(x);
    double entero = Math.Floor(x); //Por convencio toma el entero mas grande que sea menor

    Console.WriteLine("\nValor absoluto: " + absoluto);
    Console.WriteLine("Cuadrado: " + cuadrado);
    Console.WriteLine("Raiz cuadrada: " + raiz);
    Console.WriteLine("Seno: " + seno);
    Console.WriteLine("Coseno: " + coseno);
    Console.WriteLine("Entero menor mas proximo: " + entero);
}
else
{
    Console.WriteLine("No se ingreso un numero");
}

Console.WriteLine("\n\nIngrese dos numeros a comparar: ");

float y, z;
bool controlDos = float.TryParse(Console.ReadLine(), out y);
bool controlTres = float.TryParse(Console.ReadLine(), out z);

if (controlDos && controlTres)
{
    float maximo = Math.Max(y, z);
    float minimo = Math.Min(y, z);

    Console.WriteLine("\nEl maximo entre los numeros ingresados es: " + maximo);
    Console.WriteLine("El minimo entre los numeros ingresados es: " + minimo);
}
else
{
    Console.WriteLine("No se ingreso un numero");
}
