var number1 = String.Empty;
var number2 = String.Empty;
var number3 = String.Empty;
var numberInt1 = 0;
var numberInt2 = 0;
var numberInt3 = 0;

Console.Write("Ingrese el primer número: ");
number1 = Console.ReadLine()!;
int.TryParse(number1, out numberInt1);

Console.Write("Ingrese el segundo número: ");
number2 = Console.ReadLine()!;
int.TryParse(number2, out numberInt2);

Console.Write("Ingrese el tercer número: ");
number3 = Console.ReadLine()!;
int.TryParse(number3, out numberInt3);

if (numberInt1 > numberInt2 && numberInt2 > numberInt3)
{
    Console.WriteLine($@"
     El numero mayor es: {number1}
     El del numero del medio es: {number2} 
     El numero menor es: {number3} 
");
}
else if (numberInt2 > numberInt1 && numberInt1 > numberInt3)
{
    Console.WriteLine($@"
    El numero mayor es: {number2}
    El numero del medio es: {number1} 
    El numero menor: {number3} 
");
}
else
{
    Console.WriteLine($@"
    El numero mayor es: {number3}
    El numero del medio es: {number2} 
    El numero menor es: {number1} 
");
}