/*
Practica 1 - If Conditional - Exercise 2.1.08
----------------------------------------------------------------------
English:
Three positive numbers are read. 
Determine whether they are the lengths of the sides of a triangle. 
Remember that in any triangle, each side is less than or equal to the sum of the other two sides and less than their difference (it is sufficient to show this for one side). 
If so, report whether the triangle is:

Equilateral (3 equal sides),
Isosceles (2 equal sides), or
Scalene (3 different sides)

Spanish: 
Se leen tres números positivos. 
Determinar si son las longitudes de los lados de un triángulo: 
Recordar que en todo triangulo cada lado es menor o igual que la suma de los
otros dos y menor que su diferencia (basta mostrarlo para un lado). 
En caso afirmativo, informar si el mismo es:

equilátero (3 lados iguales), 
isósceles (2 lados iguales) o
escaleno (3 lados distintos).
----------------------------------------------------------------------
*/

string op;

Console.Write("Ingresar un lado: ");
if (!int.TryParse(Console.ReadLine()!, out int lado1))
{
    Console.WriteLine("Se debe ingresar un dato de tipo numerico");
    return;
}
if (!int.TryParse(Console.ReadLine()!, out int lado2))
{
    Console.WriteLine("Se debe ingresar un dato de tipo numerico");
    return;
}
if (!int.TryParse(Console.ReadLine()!, out int lado3))
{
    Console.WriteLine("Se debe ingresar un dato de tipo numerico");
    return;
}


if (lado1 + lado2 + lado3 == 180)
{

    if ((lado1 is 90) && (lado2 is 90) && (lado3 is 90))
    {
        Console.WriteLine("Es un triangulo Equilatero.");
    }
}
else
    Console.WriteLine("Las medidas ingresadas no pertenecen a ningun tipo de triangulo.");



