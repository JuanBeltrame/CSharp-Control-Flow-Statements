/* 
Practica 1 - If Conditional - Exercise 2.2.01
----------------------------------------------------------------------
English:
Enter 5 numbers 
saving them in a scalar variable. 
Then calculate and display: the maximum value, the minimum value and the average.

Spanish: 
Ingresar 5 números por consola, 
guardándolos en una variable escalar. 
Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
----------------------------------------------------------------------
*/

//------------Programa Principal------------------
using Microsoft.Win32.SafeHandles;

Console.Write("Ingresar el Primer numero: ");
if(!int.TryParse(Console.ReadLine(), out int n1))
{
    Console.WriteLine("El numero ingresado no es un numero");
}

Console.Write("Ingresar el Segundo numero: ");
if (!int.TryParse(Console.ReadLine(), out int n2))
{
    Console.WriteLine("El numero ingresado no es un numero");
}

Console.Write("Ingresar el Tercer numero: ");
if(!int.TryParse(Console.ReadLine(), out int n3))
{
    Console.WriteLine("El numero ingresado no es un numero");
}

Console.Write("Ingresar el Cuarto numero: ");
if(!int.TryParse(Console.ReadLine(), out int n4))
{
    Console.WriteLine("El numero ingresado no es un numero");
}
Console.Write("Ingresar el Quinto numero: ");
if(!int.TryParse(Console.ReadLine(), out int n5))
{
    Console.WriteLine("El numero ingresado no es un numero");
}

int max = n1;
int minimo = n1;


if (n2 > max)
{
    max = n2;
}
else if (n2 < minimo)
{
    minimo = n2;
}

if (n3 > max)
{
    max = n3;
}
else if (n3 < minimo)
{
    minimo = n3;
}

if (n4 > max)
{
    max = n4;
}
else if (n4 < minimo)
{
    minimo = n4;
}

if (n5 > max)
{
    max = n5;
}
else if (n5 < minimo)
{
    minimo = n5;
}


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.Write("El numero mas grande ingresado es el numero: " + max);
decimal promedio = (n1 + n2 + n3 + n4 + n5) / 5;

Console.WriteLine();
Console.Write("El numero mas chico ingresado es el numero: " + minimo);

Console.WriteLine();
Console.Write("El promedio obtenido en funcion a los numeros ingresados es: " + promedio);

Console.ReadKey();