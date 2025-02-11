/*
Practica 1 - If Conditional - Exercise 2.1.06
----------------------------------------------------------------------
English:
Enter three capital letters and display them in alphabetical order.

Spanish: 
Ingresar tres letras mayúsculas y mostrarlas ordenadas alfabéticamente.
----------------------------------------------------------------------
*/

Console.Title = "Practica 1 - If Conditional - Exercise 2.1.06";
Console.ForegroundColor = ConsoleColor.Yellow;

GenerateRandomValue(out char firstLetter, out char secondLetter, out char thirdLetter);

Console.Write($"Ingresar la primera letra mayuscula: {firstLetter}");
Console.WriteLine();

Console.Write($"Ingresar la segunda letra mayuscula: {secondLetter}");
Console.WriteLine();

Console.Write($"Ingresar la tercera letra mayuscula: {thirdLetter}");
Console.WriteLine();


if (firstLetter > secondLetter)
{
    Console.WriteLine();
}







static void GenerateRandomValue(out char firstLetter, out char secondLetter, out char thirdLetter)
{
    Random rn = new();
    firstLetter = (char)rn.Next(65, 91);
    secondLetter = (char)rn.Next(65, 91);
    thirdLetter = (char)rn.Next(65, 91);
}
