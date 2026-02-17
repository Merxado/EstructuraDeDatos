using CodesShare;

var answer = string.Empty;
var options = new List<string> { "si", "no" };
do
{
    
    var number = Extensions.GetInt("Ingrese un numero entero diferente de cero: ");
    if (number == 0)
    {
        continue;
    }

    if (number % 2 == 0)
    {
        Console.WriteLine($"El numero {number} es par");
    }
    else
    {
        Console.WriteLine($"El numero {number}, es impar");
    }

    do
    {
        answer = Extensions.GetString("¿Desea ingresar otro numero? (si/no): ", options);
        
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Fin del ejercicio, gracias por participar");

