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
System.Console.WriteLine("Ingresar 3 Numeros: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
if (number1 < number2 && number2 < number3)
    System.Console.WriteLine("Los numeros ingresaron en orden creciente");
else
    System.Console.WriteLine("Los numeros NO ingresaron en orden creciente");
