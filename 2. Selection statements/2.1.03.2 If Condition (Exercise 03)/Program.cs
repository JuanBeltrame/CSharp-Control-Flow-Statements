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

int angle1;
int angle2;
int angle3;
string result; 

Console.Write("Ingresar medida del primer angulo: "); 
angle1 = int.Parse(Console.ReadLine()!);
Console.Write("Ingresar medida del segundo angulo: ");
angle2 = int.Parse( Console.ReadLine()!);
Console.Write("Ingresar medida del tercer angulo: "); 
angle3 = int.Parse(Console.ReadLine()!);

if (angle1 == 90 || angle2 == 90 || angle3 == 90)
   result = angle1 + angle2 + angle3 == 180 ? "Es un triangulo rectangulo" : "Las medidas ingresadas no corresponden a un rectangulo";
else
    result = angle1 + angle2 + angle3 == 180 ? "No es un triangulo rectangulo" : "Ni siquiera es un triangulo";

Console.WriteLine(result);



