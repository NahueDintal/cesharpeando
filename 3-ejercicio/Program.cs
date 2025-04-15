// Ingresar por teclado el total de una venta, el procentaje de descuenteo y calcular el total a pagar

Console.WriteLine(":: Descuento de Venta!");

Console.Write(":: Ingrese el valor del subtotal!");
double subtotal = Convert.ToDouble(Console.ReadLine());

Console.Write(":: Ingrese el valor del porcentaje de descuento!");
double porcentaje = Convert.ToDouble(Console.ReadLine());

double descuento = subtotal * porcentaje / 100;

double total = subtotal - descuento;
Console.Write($"\n:: El total a pagar es de: {total} ");
