/*
Practica 1 - If Conditional - Exercise 2.1.04
----------------------------------------------------------------------
English:
Enter three distinct integer numbers. 
Determine and display whether they were entered in ascending order.

Spanish: 
Ingresar tres números enteros distintos. 
Determinar y mostrar si ingresaron en orden creciente.
----------------------------------------------------------------------
*/
Console.Title = "Practica 1 - If Conditional - Exercise 2.1.04";


Console.Write("Ingresar el PRIMER NUMERO: ");
if (!int.TryParse(Console.ReadLine(), out int numberA))
{
    Console.WriteLine($"El pimer valor ingresado, no es un numero");
    return;
}

Console.Write("Ingresar el SEGUNDO NUMERO: ");
if (!int.TryParse(Console.ReadLine(), out int numberB))
{
    Console.WriteLine($"El segundo valor ingresado, no es un numero");
    return;
}

Console.Write("Ingresar el TERCER NUMERO: ");
if (!int.TryParse(Console.ReadLine(), out int numberC))
{
    Console.WriteLine($"El tercer valor ingresado, no es un numero");
    return;
}

if (!(numberA != numberB) || !(numberA != numberC) || !(numberB != numberC))
    Console.WriteLine("Existen numeros repetidos");

if((numberA < numberB) || (numberB < numberC))
    Console.WriteLine($"Los numeros se ingresaron en orden creciente {numberA}, {numberB}, {numberC}");
else
    Console.WriteLine($"Los numeros se ingresaron de manera desordenada {numberA}, {numberB}, {numberC}");




