/* 
Practica 1 - If Conditional - Exercise 2.1.09
----------------------------------------------------------------------
English:


Spanish: 
Una distribuidora de libros vende a librerías y a particulares. 
Aplica bonificaciones por cantidad según el siguiente criterio:
- Librerías: hasta 24 unidades, el 20%; más de 24 unidades, el 25%.
- Particulares: menos de 6 unidades, nada; desde 6 hasta 18 unidades, el
5%; y más de 18 unidades, el 10%.

El tipo de cliente está codificado: 'L' para librerías, 'P' para particular.
Dado el importe bruto total de una compra de libros, el tipo de cliente y la cantidad
total pedida por el mismo, determinar el importe bruto bonificado.
----------------------------------------------------------------------
*/


Console.Title = "Practica 1 - If Conditional - Exercise 2.1.09";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Ingresar tipo de Cliente L (Libreria) / P (Particular): ");
char tipoCliente = char.Parse(Console.ReadLine()!);
decimal bonificacion = default;

if (tipoCliente == 'L')
{
    Console.WriteLine("Usted selecciono tipo de cliente: LIBRERIAS");

    Console.Write("Ingresar la cantidad de unidades vendidas: ");
    int cantidadVentas = int.Parse(Console.ReadLine()!);

    Console.Write("Ingresar el monto total de la venta: $");
    decimal totalDeVenta = decimal.Parse(Console.ReadLine()!);

    if (cantidadVentas <= 24)
    {
        bonificacion = totalDeVenta * 0.80M;
    }
    else if (cantidadVentas > 24)
    {
        bonificacion = totalDeVenta * 0.75M;
    }

    Console.WriteLine($"El importe final a abonar es: {bonificacion}");
}
else if (tipoCliente == 'P')
{
    Console.WriteLine("Usted selecciono tipo de cliente: PARTICULAR");
    Console.Write("Ingresar la cantidad de unidades vendidas: ");
    int cantidadVentas = int.Parse(Console.ReadLine()!);

    Console.Write("Ingresar el monto total de la venta: $");
    decimal totalDeVenta = decimal.Parse(Console.ReadLine()!);


    if (cantidadVentas > 18)
    {
        bonificacion = totalDeVenta * 0.90M;
    }
    else if (cantidadVentas >= 6 && cantidadVentas <= 18)
    {
        bonificacion = totalDeVenta * 0.95M;
    }
    else
    {
        Console.WriteLine("Cantidad de ventas menores a 6 ventas no se aplica bonificacion");
        bonificacion = totalDeVenta;
    }

    Console.WriteLine($"El importe final a abonar es: {bonificacion}");
}
else
{
    Console.WriteLine("Seleccione solamente L o P");
}
