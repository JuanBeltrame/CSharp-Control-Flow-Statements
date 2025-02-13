/*
Practica 1 - If Conditional - Exercise 2.1.06
----------------------------------------------------------------------
English:
Enter three capital letters and display them in alphabetical order.

Spanish: 
Ingresar tres letras mayúsculas y mostrarlas ordenadas alfabéticamente.
----------------------------------------------------------------------
*/

using System.Runtime.InteropServices;

Console.Title = "Practica 1 - If Conditional - Exercise 2.1.06";
Console.ForegroundColor = ConsoleColor.Yellow;

GenerateRandomValue(out char firstLetter, out char secondLetter, out char thirdLetter);

Console.Write($"Ingresar la primera letra mayuscula: {firstLetter}");
Console.WriteLine();

Console.Write($"Ingresar la segunda letra mayuscula: {secondLetter}");
Console.WriteLine();

Console.Write($"Ingresar la tercera letra mayuscula: {thirdLetter}");
Console.WriteLine();

char[] letters = [firstLetter, secondLetter, thirdLetter];
SortLetters(letters);
Console.WriteLine();
DisplayLetters(letters);



static void GenerateRandomValue(out char firstLetter, out char secondLetter, out char thirdLetter)
{
    Random rn = new();
    firstLetter = (char)rn.Next(65, 91);
    secondLetter = (char)rn.Next(65, 91);
    thirdLetter = (char)rn.Next(65, 91);
}

static void SortLetters(char[] letters)
{
    for (int i = 0; i < letters.Length - 1; i++)
    {
        for (int j = i + 1; j < letters.Length; j++)
        {
            if (letters[i] > letters[j])
            {
                char aux = letters[i];
                letters[i] = letters[j];
                letters[j] = aux;
            }
        }
    }
}

static void DisplayLetters(char[] letters)
{
    Console.Write("Ordenadas quedarian asi: ");
    for (int i = 0; i < letters.Length; i++)
        Console.Write($"{letters[i] } ");
    Console.WriteLine();
}
