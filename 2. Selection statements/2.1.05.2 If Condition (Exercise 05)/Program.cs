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

Console.Title = "Practica 1 - If Conditional - Exercise 2.1.05";

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Enter three numbers: ");
Console.Write($"First: "); int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write($"Second: "); int secondNumber = int.Parse(Console.ReadLine()!);
Console.Write("Third: "); int thirdNumber = int.Parse(Console.ReadLine()!);

DisplayNumbers(firstNumber, secondNumber, thirdNumber);
EvaluateValues(firstNumber, secondNumber, thirdNumber);

static void EvaluateValues(int n1, int n2, int n3)
{
    if ((n1 < n2) && (n1 < n3))
        Console.WriteLine("El primer numero ingresado es menor que los otros dos");
    else
        Console.WriteLine("El primer numero ingresado no es el menor de los tres");
}
static void DisplayNumbers(int n1, int n2, int n3)
{
    List<int> numberList = [n1, n2, n3];
    Console.Write($"Numbers are: ");
    foreach (int number in numberList)
        Console.Write($"{number} ");

    Console.WriteLine();
}
