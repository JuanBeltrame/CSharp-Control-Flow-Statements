/*
Practica 1 - If Conditional - Exercise 2.1.05
----------------------------------------------------------------------
English:
Determine if the first of a set of three given numbers 
is less than the other two.

Spanish: 
Determinar si el primero de un conjunto de tres números dados, 
es menor que los otros dos.
----------------------------------------------------------------------
*/
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Ingresar tres numeros: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

int valorMinimo = number1;

if (valorMinimo < number2 && valorMinimo < number3)
    System.Console.WriteLine($"{valorMinimo} es menor que {number2} y {number3}");
else
    System.Console.WriteLine($"{valorMinimo} NO es menor que {number2} y {number3}");
