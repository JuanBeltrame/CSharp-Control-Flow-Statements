/*
Practica 1 - If Conditional - Exercise 2.1.02
----------------------------------------------------------------------
English:
Given a number determine whether it is positive or negative.

Spanish: 
Dado un número determinar si es positivo o negativo.
----------------------------------------------------------------------
*/
System.Console.Write("Ingresar un numero: ");
int numero = int.Parse(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine($"El numero: {numero} ingresado, es POSITIVO");
}
else
{
    Console.WriteLine($"El numero: {numero} ingresado, es NEGATIVO");
}