// See https://aka.ms/new-console-template for more information
int seguir = 1;
do
{
    Console.WriteLine("-----Calculadora Basica-----\n");
    Console.WriteLine("1.Suma\n2.Resta\n3.Multiplicacion\n4.Division");
    int operacion;
    int.TryParse(Console.ReadLine(), out operacion);

    Console.WriteLine("Ingrese los dos operando: ");

    float num1, num2, resultado = 0;
    bool control1 = float.TryParse(Console.ReadLine(), out num1);
    bool control2 = float.TryParse(Console.ReadLine(), out num2);

    if (control1 && control2)
    {
        switch (operacion)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("\nOperacioon no valida\n");
                break;
        }

        Console.WriteLine("\nResultado: " + resultado);
    }
    else
    {
        Console.WriteLine("\nNo se ingreso un numero");
    }

    Console.WriteLine("¿Desea realizar otra operacion? //1 = si //");
    int.TryParse(Console.ReadLine(), out seguir);
} while (seguir == 1);

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
    double entero = Math.Floor(x); //Por convencion toma el entero mas grande que sea menor

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

