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

double subtotal = precio * cantidad;

double total = 0;
double recargo = 0;
double descuento = 0;

Console.WriteLine(":: Ingrese la opción de pago, 1 efectivo, 2 credito!");
int opcion = Convert.ToInt32(Console.ReadLine());

if (opcion == 1)
        {
            if (subtotal >= 100000)
            {
                descuento = subtotal * 0.10;
            }
            total = subtotal - descuento;
        }
        else if (opcion == 2)
        {
            recargo = subtotal * 0.30;
            total = subtotal + recargo;
        }
        else
        {
            Console.WriteLine("Opción inválida");
            return;
        }

        // Mostrar resultados
        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine($"Subtotal: {subtotal:C}");
        if (opcion == 1)
        {
            Console.WriteLine($"Descuento: {descuento:C}");
        }
        else
        {
            Console.WriteLine($"Recargo: {recargo:C}");
        }
        Console.WriteLine($"Total a pagar: {total:C}");
