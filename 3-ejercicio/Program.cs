// Ingresar por teclado el total de una venta, el procentaje
// de descuenteo y calcular el total a pagar.
// Inicio
Console.WriteLine(":: Descuento de Venta!");
// Entrada
Console.Write(":: Ingrese el valor del subtotal!");
double subtotal = Convert.ToDouble(Console.ReadLine());
Console.Write(":: Ingrese el valor del porcentaje de descuento!");
double porcentaje = Convert.ToDouble(Console.ReadLine());
// Proceso
double descuento = subtotal * porcentaje / 100;
double total = subtotal - descuento;
// Salida
Console.WriteLine($":: El sub total es de: {subtotal}");
Console.WriteLine($":: El porcentaje es de: {porcentaje}");
Console.WriteLine($":: El total a pagar es de: {total}");
// Fin!
