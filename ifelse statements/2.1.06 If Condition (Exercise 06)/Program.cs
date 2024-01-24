/*
Practica 1 - If Conditional - Exercise 2.1.06
----------------------------------------------------------------------
English:
Enter three capital letters and display them in alphabetical order.

Spanish: 
Ingresar tres letras mayúsculas y mostrarlas ordenadas alfabéticamente.
----------------------------------------------------------------------
*/

System.Console.WriteLine("Ingresar Tres Letras");
char letter1 = char.Parse(Console.ReadLine());
char letter2 = char.Parse(Console.ReadLine());
char letter3 = char.Parse(Console.ReadLine());

char letter1Mayus = char.ToUpper(letter1);
char letter2Mayus = char.ToUpper(letter2);
char letter3Mayus = char.ToUpper(letter3);

if (letter1Mayus < letter2Mayus && letter2Mayus < letter3Mayus)
{
    Console.WriteLine($"{letter1Mayus} {letter2Mayus} {letter3Mayus}");
}
else if (letter1Mayus < letter3Mayus && letter3Mayus < letter2Mayus)
{
    Console.WriteLine($"{letter1Mayus} {letter3Mayus} {letter2Mayus}");
}
else if (letter2Mayus < letter1Mayus && letter1Mayus < letter3Mayus)
{
    Console.WriteLine($"{letter2Mayus} {letter1Mayus} {letter3Mayus}");
}
else if (letter2Mayus < letter3Mayus && letter3Mayus < letter1Mayus)
{
    Console.WriteLine($"{letter2Mayus} {letter3Mayus} {letter1Mayus}");
}
else if (letter3Mayus < letter1Mayus && letter1Mayus < letter2Mayus)
{
    Console.WriteLine($"{letter3Mayus} {letter1Mayus} {letter2Mayus}");
}
else if (letter3Mayus < letter2Mayus && letter2Mayus < letter1Mayus)
{
    Console.WriteLine($"{letter3Mayus} {letter2Mayus} {letter1Mayus}");
}
