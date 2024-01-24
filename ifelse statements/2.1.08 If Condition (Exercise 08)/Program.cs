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


int numeroA = int.Parse(Console.ReadLine()!);
int numeroB = int.Parse(Console.ReadLine()!);
int numeroC = int.Parse(Console.ReadLine()!);


if (EsTriangulo(numeroA, numeroB, numeroC))
{
    if (numeroA == numeroB & numeroB == numeroC)
    {
        Console.WriteLine("Es un triangulo EQUILATERO ");
    }
    else if (numeroA != numeroB && numeroB != numeroC)
    {
        Console.WriteLine("Es un triangulo ESCALENO");
    }
    else
    {   
        Console.WriteLine("Es un triangulo ISOSCELES");
    }
}
else
{
    Console.WriteLine("No es un triangulo Valido");
}

static bool EsTriangulo(int a, int b, int c)
{
    if (a <= b + c && b <= a + c && c <= a + b && a < Math.Abs(b - c) && b< Math.Abs(a - c) && c < Math.Abs(a - b))
        return true;
    else
        return false;
}

