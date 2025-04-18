//Ingresar por teclado el precio, cantidad y la forma de pago de acuerdo a
//los siguientes códigos 1Efectivo 2Crédito.
//Si el monto abonado es efectivo y supera los $ 100.000 debe aplicar un
//10 por ciento de descuezo, pero si es en crédito tiene un recargo del 30
//por ciento. En ambos casos debe imprimir el subtotal , descuento o
//recargo y el total de la operación.
// Inicio
Console.WriteLine(":: Calculadora de método de pago!");
Console.WriteLine(":: Ingrese precio!");
// Entrada
double precio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(":: Ingrese la cantidad de productos!");
int cantidad = Convert.ToInt32(Console.ReadLine());
// Proceso
double subtotal = precio * cantidad;
// Entradas en default
double total = 0;
double recargo = 0;
double descuento = 0;
// Entrada de la forma de pago
Console.WriteLine(":: Ingrese la opción de pago, 1 efectivo, 2 credito!");
int opcion = Convert.ToInt32(Console.ReadLine());
// Condicional para discriminar la forma de pago
if (opcion == 1)
  {
    // Discrimina si el subtotal supera los $100mil
    // para hacer el descuento
     if (subtotal >= 100000)
    {
      // Proceso
      descuento = subtotal * 0.10;
    }
      total = subtotal - descuento;
  }
  else if (opcion == 2)
    {
      // Proceso
      recargo = subtotal * 0.30;
      total = subtotal + recargo;
    }
    else
    {
      // Mensaje en caso de ingresar un valor que no es opción!
      Console.WriteLine(":: Escribí bien o te mato!!");
      return;
    }

// Salida, mostrar resultados
Console.WriteLine(":: Detalle de la compra:");
Console.WriteLine($":: Subtotal: ${subtotal}");
if (opcion == 1)
{
  Console.WriteLine($":: Descuento: ${descuento}");
}
else
{
  Console.WriteLine($":: Recargo: ${recargo}");
}
Console.WriteLine($":: Total a pagar: ${total}");
// Fin!
