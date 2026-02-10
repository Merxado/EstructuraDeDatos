var numberString = String.Empty;
do
{
    Console.Write("Ingrese un numero o la palabra 'Salir' para finalizar: ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "salir")
    {
        Console.WriteLine("Saliendo del programa...");
        break;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberString} es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }
    }
    else
    {
        Console.WriteLine($"El valor {numberString}, ingresado no es un numero valido");
    }
} while (numberString.ToLower() != "salir");

