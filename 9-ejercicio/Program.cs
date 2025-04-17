//Ingresar por teclado el precio, cantidad y la forma de pago de acuerdo a
//los siguientes códigos 1Efectivo 2Crédito.
//Si el monto abonado es efectivo y supera los $ 100.000 debe aplicar un
//10 por ciento de descuezo, pero si es en crédito tiene un recargo del 30
//por ciento. En ambos casos debe imprimir el subtotal , descuento o
//recargo y el total de la operación.

// Entrada
Console.WriteLine(":: Ingrese precio!");
double precio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(":: Ingrese la cantidad de productos!");
int cantidad = Convert.ToInt32(Console.ReadLine());
// Proceso
double subtotal = precio * cantidad;
Console.WriteLine(subtotal);
Console.WriteLine(":: Ingrese el opción de pago, 1 efectivo, 2 credito!");
int opcion = Convert.ToInt32(Console.ReadLine());

double porcentaje = Convert.ToDouble(Console.ReadLine());
// Proceso
double descuento = (subtotal * porcentaje / 100);
Console.WriteLine(descuento);

double total = (subtotal - descuento);
Console.WriteLine(total);
