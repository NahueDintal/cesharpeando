// Ingresar por teclado el precio, cantidad y el
// porcentaje de descuento y calcular el total a pagara.
// Inicio
Console.WriteLine(":: Descuento de Venta!");
// Entrada
Console.WriteLine(":: Ingrese precio!");
double precio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(":: Ingrese la cantidad de productos!");
int cantidad = Convert.ToInt32(Console.ReadLine());
// Proceso
double subtotal = precio * cantidad;
Console.WriteLine(subtotal);
// Ingreso
Console.WriteLine(":: Ingrese el porcentaje de descuento!");
double porcentaje = Convert.ToDouble(Console.ReadLine());
// Proceso
double descuento = (subtotal * porcentaje / 100);
double total = (subtotal - descuento);
// Salida
Console.WriteLine($":: El subtotal es de: ${subtotal}");
Console.WriteLine($":: El descuento es de: ${descuento}");
Console.WriteLine($":: El total es de: ${total}");
// Fin!
