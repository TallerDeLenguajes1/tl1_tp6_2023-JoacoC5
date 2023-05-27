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



