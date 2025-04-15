// Ingresar por teclado el precio, cantidad y el porcentaje de descuento y calcular el total a pagar

Console.WriteLine(":: Descuento de Venta!");

Console.WriteLine(":: Ingrese precio!");
double precio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(":: Ingrese la cantidad de productos!");
int cantidad = Convert.ToInt32(Console.ReadLine());

double subtotal = precio * cantidad;
Console.WriteLine(subtotal);

Console.WriteLine(":: Ingrese el porcentaje de descuento!");
double porcentaje = Convert.ToDouble(Console.ReadLine());

double descuento = (subtotal * porcentaje / 100);
Console.WriteLine(descuento);

double total = (subtotal - descuento);
Console.WriteLine(total);
