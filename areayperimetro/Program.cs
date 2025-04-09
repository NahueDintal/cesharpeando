Console.WriteLine(":: Calculadora de Area y perimetro!");

Console.Write(":: Ingrese el valor de base!");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write(":: Ingrese el valor de altura!");
double h = Convert.ToDouble(Console.ReadLine());

double area = b * h;
double perimetro = 2 * (b + h);
Console.WriteLine($"\n:: Area: {area}");
Console.WriteLine($"\n:: Perimetro: {perimetro}");
