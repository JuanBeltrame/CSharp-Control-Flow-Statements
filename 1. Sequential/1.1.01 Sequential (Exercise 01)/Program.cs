/*
Practica 1 - Sequential - Exercise 1.1.01
----------------------------------------------------------------------
English:
Given two numbers entered via keyboard as data, 
calculate their sum and report the result. 
Declare the variables to be used: N1, N2, SUM, all of numerical type.

Spanish: 
Dados como datos (ingresados por teclado) dos números cualesquiera 
calcular su suma e informar el resultado.
Declarar las variables a utilizar N1, N2, SUMA de tipo numérico
----------------------------------------------------------------------
*/

static int CalculteSum(int firstValue, int secondValue) => firstValue + secondValue;

int firstValue = default;
int secondValue = default;


firstValue = int.Parse(Console.ReadLine()!);
secondValue = int.Parse(Console.ReadLine()!);
int result = CalculteSum(firstValue, secondValue);
Console.WriteLine(result);



