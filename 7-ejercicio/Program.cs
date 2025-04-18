// Hacer un programa que me permita calcular áreas
// de acuerdo a las siguientes figuras: circulo, rectangulo, triangulo.
// El usuario debe ingresar el código de la figura y en base al código
// ingresado debe pedir los datos para calcular el aérea correspondiente.
// Inicio
Console.WriteLine(":: Calculadora de Area!");
Console.WriteLine(":: Ingresa 1 para circulo");
Console.WriteLine(":: Ingresa 2 para rectangulo");
Console.WriteLine(":: Ingresa 3 para triangulo");
// Entrada
int opcion = Convert.ToInt32(Console.ReadLine());
// Condicional dependiendo de la entrada
if ( opcion == 1 ) {
  // Entrada
  Console.WriteLine(":: Ingresa el radio del circulo");
  double r = Convert.ToDouble(Console.ReadLine());
  // Proceso
  double area = ( r * 2 * 3.14 );
  // Salida
  Console.WriteLine($":: El area del circulo es: {area}");
} else if ( opcion == 2 ) {
  // Entrada
  Console.WriteLine(":: Ingresa los valores de Base");
  double b = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine(":: Ingresa los valores de Altura");
  double h = Convert.ToDouble(Console.ReadLine());
  // Proceso
  double area = (b * h);
  // Salida
  Console.WriteLine($":: El area del rectangulo es: {area}");
} else if ( opcion == 3 ) {
  // Entrada
  Console.WriteLine(":: Ingresa los valores de Base");
  double b = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine(":: Ingresa los valores de Altura");
  double h = Convert.ToDouble(Console.ReadLine());
  // Proceso
  double area = (b * h)/2;
  // Salida
  Console.WriteLine($":: El area del triangulo es: {area}");
} else {
  // Salida en caso de poner un número que no es opción!
  Console.WriteLine(":: Escribí bien gorreado/a!!");
return;
}
// Fin!
