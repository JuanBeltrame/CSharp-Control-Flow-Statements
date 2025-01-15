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

System.Console.Write("Ingresar TIPO de pieza, 'A' o 'B: ");
char tipoPieza = char.Parse(Console.ReadLine());
char tipoPiezaMayus = char.ToUpper(tipoPieza);

if (tipoPiezaMayus != 'A' && tipoPiezaMayus != 'B')
    System.Console.WriteLine("Los tipos de piezas solo pueden ser de TIPO 'A' o 'B'");
else if (tipoPiezaMayus == 'A')
{
    Console.Write($"Ingresar la medida de la pieza {tipoPiezaMayus}: ");
    int medidaPiezaA = int.Parse(Console.ReadLine());
    if (medidaPiezaA >= 163 && medidaPiezaA <= 167)
        System.Console.WriteLine($"La pieza {tipoPiezaMayus}, cumple con las medidas especificadas");
    else
        System.Console.WriteLine($"La pieza {tipoPiezaMayus}, NO cumple con las medidas especificadas");
}
else if (tipoPiezaMayus == 'B')
{
    Console.Write($"Ingresar la medida de la pieza {tipoPiezaMayus}: ");
    int medidaPiezaB = int.Parse(Console.ReadLine());
    if (medidaPiezaB >= 177 && medidaPiezaB <= 183)
        System.Console.WriteLine($"La pieza {tipoPiezaMayus}, cumple con las medidas especificadas");
    else
        System.Console.WriteLine($"La pieza {tipoPiezaMayus}, NO cumple con las medidas especificadas");
}
