/* 
Practica 1 - If Conditional - Exercise 2.1.10
----------------------------------------------------------------------
English:


Spanish: 
Dado como dato la cantidad de kilowatios consumidos por un usuario en un mes,
calcular y mostrar el importe a pagar por el mismo, teniendo en cuenta que:
- Si la cantidad de kilowatios consumidos es menor o igual a 200, el precio del
kilowatio es de 0.05 pesos.
- Si la cantidad de kilowatios consumidos es mayor que 200 y menor que 1000, el
precio del kilowatio es de 0.1 pesos.
- Si la cantidad de kilowatios consumidos es mayor o igual que 1000, el precio
del kilowatio es de 0.15 pesos.
----------------------------------------------------------------------
*/

//------------Programa Principal------------------

decimal kilowatts = default;
decimal precio = default;

Console.Title = "Practica 1 - If Conditional - Exercise 2.1.10";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("------------------------");
Console.WriteLine("Bienvenido");
Console.WriteLine("------------------------");

Console.Write("Ingresar la Cantidad de KW: ");
while (!decimal.TryParse(Console.ReadLine(), out kilowatts))
{
    Console.Write("Ingreso de datos invalido. Ingresar la cantidad de KW: ");
}


if (kilowatts <= 200)
{
    precio = kilowatts * 0.05M;
}
else if (kilowatts > 200 && kilowatts < 1000)
{
    precio = kilowatts * 0.1M;
}
else
{
    precio = kilowatts * 0.15M;
}

Console.WriteLine($"El monto a pagar es de: {precio}");

