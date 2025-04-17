Console.WriteLine(":: Calculadora de Area!");

Console.WriteLine(":: Ingresa 1 para circulo");
Console.WriteLine(":: Ingresa 2 para rectangulo");
Console.WriteLine(":: Ingresa 3 para triangulo");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
  case 1:
  calculoDeAreaCirculo();
  break;
  case 2:
  calculoDeAreaRectangulo();
  break;
  case 3:
  calculoDeAreaTriangulo();
  break;
  default: 
  Console.WriteLine(":: Ingresa una opción válida gorreado/a!!");
  break;
}

static void calculoDeAreaTriangulo()
{
Console.WriteLine(":: Ingresa los valores de Base");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(":: Ingresa los valores de Altura");
double h = Convert.ToDouble(Console.ReadLine());

double area = (b * h)/2;
Console.WriteLine($":: El area del triangulo es: {area}");
}


static void calculoDeAreaCirculo()
{
Console.WriteLine(":: Ingresa el radio del circulo");
double r = Convert.ToDouble(Console.ReadLine());

double area = ( r * 2 * 3.14 );
Console.WriteLine($":: El area del circulo es: {area}");
}


static void calculoDeAreaRectangulo()
{
Console.WriteLine(":: Ingresa los valores de Base");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(":: Ingresa los valores de Altura");
double h = Convert.ToDouble(Console.ReadLine());

double area = (b * h);
Console.WriteLine($":: El area del rectangulo es: {area}");
}
