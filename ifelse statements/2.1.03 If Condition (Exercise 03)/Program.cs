/*
Practica 1 - If Conditional - Exercise 2.1.03
----------------------------------------------------------------------
English:
Given the measurement of each of the three angles of a triangle, determine and report through a message whether they belong to a right triangle or not.

Spanish: 
Dada la medida de cada uno de los tres ángulos de un triángulo determinar e informar
mediante un mensaje si pertenecen o no a un triángulo rectángulo.
----------------------------------------------------------------------
*/
Console.Write("Ingresar la medida 1/3: ");
int angle1 = int.Parse(Console.ReadLine());
Console.Write("Ingresar la medida 2/3: ");
int angle2 = int.Parse(Console.ReadLine());
Console.Write("Ingresar la medida 3/3: ");
int angle3 = int.Parse(Console.ReadLine());

if (angle1 + angle2 + angle3 != 180)
{
    System.Console.WriteLine("Las medidas ingresadas no corresponden a un triangulo ");
}
else if ((angle1 == 90) || (angle2 == 90) || (angle3 == 90))
{
    System.Console.WriteLine("Las medidas ingresadas pertenecen a un triangulo rectangulo");
}
