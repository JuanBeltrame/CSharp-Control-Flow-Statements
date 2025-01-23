/*
Practica 1 - If Conditional - Exercise 2.1.02
----------------------------------------------------------------------
English:
Given a number determine whether it is positive or negative.

Spanish: 
Dado un número determinar si es positivo o negativo.
----------------------------------------------------------------------
*/

using System.Timers;

Random rn = new();
int rnValue = rn.Next(-10,10);
Console.WriteLine($". Valor: {rnValue}");
CheckPositive(rnValue);


static void CheckPositive(int value) 
{
string result = value > 0 ? "El valor es POSITIVO" : "El valor es negativo";
Console.WriteLine(result);
}

