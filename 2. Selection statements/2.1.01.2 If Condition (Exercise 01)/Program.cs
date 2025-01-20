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
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresar 2 Numeros: ");
        Console.WriteLine("Primer Valor: ");
        int firstValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Segundo Valor: ");
        int secondValue = int.Parse(Console.ReadLine()!);

        if (firstValue == secondValue)
            System.Console.WriteLine("Ambos numeros son iguales");
        else if (firstValue > secondValue)
            System.Console.WriteLine($"En orden creciente: {secondValue}, {firstValue})");
        else
            System.Console.WriteLine($"En orden creciente: {firstValue}, {secondValue})");
    }
}