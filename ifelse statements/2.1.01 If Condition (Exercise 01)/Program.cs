/*
Practica 1 - If Conditional - Exercise 2.1.01
----------------------------------------------------------------------
English:
Given two distinct numbers,
show them sorted in increasing order.

Spanish: 
Dados dos números distintos, 
mostrarlos ordenados en forma creciente.
----------------------------------------------------------------------
*/
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresar un numero");

        if(!int.TryParse(Console.ReadLine(), out int numberA))
        {
            Console.WriteLine("El numero ingresado no es un numero;");
        }

        if(!int.TryParse(Console.ReadLine(), out int numberB))
        {
            Console.WriteLine("El numero ingresado no es un numero;");
        }

        if (numberA < numberB)
        {
            Console.Write($"{numberA}, {numberB}");
        }
        else
        {
            Console.Write($"{numberB}, {numberA}");
        }
    }
}