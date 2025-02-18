/*
Practica 1 - If Conditional - Exercise 2.1.07
----------------------------------------------------------------------
English:
Quality Control of Two Types of Parts in a Factory is Desired
A and B will be used to denote the two types of parts.
a. The type of part and its measurement in millimeters are given as data.
b. It must be indicated whether it meets the specifications, knowing that
c. Type A pieces must measure 165 mm and a tolerance of +/-2 mm is allowed.
d. Type B pieces must measure 180 mm and a tolerance of +/-3 mm is allowed.

Spanish: 
Se desea controlar en una fábrica la calidad de dos tipos de piezas 
que denominaremos A y B.
a. Se dan como datos el tipo de pieza y su medida en milímetros.
b. Se debe indicar si cumple con las especificaciones sabiendo que
c. Las piezas de tipo A deben medir 165 mm y se admite un error de +/-2 mm.
d. Las piezas de tipo B deben medir 180 mm y se admite un error de +/-3 mm.
----------------------------------------------------------------------
*/

Console.Title = "Practica 1 - If Conditional - Exercise 2.1.07";
Console.ForegroundColor = ConsoleColor.Yellow;

string? result = default;

Console.Write("Indicar el Tipo de Pieza: A/B: ");
if (!char.TryParse(Console.ReadLine()!, out char value))
{
    Console.WriteLine("Se debe ingresar un tipo de dato CHAR");
    return;
}
Console.WriteLine();

Console.Write("Indicar la medida de la pieza: ");
if (!int.TryParse(Console.ReadLine()!, out int measurement))
{
    Console.WriteLine("La medida debe ser de Tipo Entero");
    return;
}

// Pattern Matching: Constant Pattern
if (value is 'A')
{
    // Logical/Relational Pattern 
    result = measurement switch
    {
        >= 163 and <= 168 => "esta dentro del rango",
        < 163 or > 168 => "esta fuera del rango"
    };
}
else if (value is 'B')
{
    result = measurement switch
    {
        >= 177 and <= 183 => "esta dentro del rango",
        < 177 or > 183 => "esta fuera del rango"
    };
}

// Aca se utilizo raw interpolated string literals
Console.WriteLine($"""
    . Se Ingreso la pieza: {value}");
    . La medida de la pieza es: {measurement}
    . La pieza {value} {result}
    """);
