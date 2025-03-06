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

Console.Title = "Practica 1 - If Conditional - Exercise 2.1.08";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Ingresar el primer lado: ");
if (!int.TryParse(Console.ReadLine()!, out int lado1) || lado1 <= 0)
{
    Console.WriteLine("Se debe ingresar un dato de tipo numerico");
    return;
}
Console.Write("Ingresar el segundo lado: ");
if (!int.TryParse(Console.ReadLine()!, out int lado2) || lado2 <= 0)
{
    Console.WriteLine("Se debe ingresar un dato de tipo numerico");
    return;
}
Console.Write("Ingresar el tercer lado: ");
if (!int.TryParse(Console.ReadLine()!, out int lado3) || lado3 <= 0)
{
    Console.WriteLine("Se debe ingresar un dato de tipo numerico");
    return;
}

bool esTriangulo = (lado1, lado2, lado3) switch
{
    var (a, b, c) when a + b > c && a + c > b && b + c > a => true,
    _ => false
};


if (esTriangulo)
{
    string tipoTriangulo = (lado1, lado2, lado3) switch
    {
        var (a, b, c) when a == b && b == c => "Es un triangulo Equilatero.",
        var (a, b, c) when a == b || b == c || a == c => "Es un triangulo Isosceles",
        _ => "Es un triangulo Escaleno"
    };

    Console.WriteLine(tipoTriangulo);
}
else
    Console.WriteLine("Las medidas ingresadas no pertenecen a ningun tipo de triangulo.");





