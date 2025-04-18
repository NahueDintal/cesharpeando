//Ingresar por teclado la base y altura de un rectángulo
//y calcular e imprimir el perímetro y arrea correspondiente.
// Inicio
Console.WriteLine(":: Calculadora de Area y perímetro!");
// Entrada
Console.WriteLine(":: Ingresa los valores de base!");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(":: Ingresa los valores de altura!");
double h = Convert.ToDouble(Console.ReadLine());
// Proceso
double area = b * h;
double perimetro = 2 * ( b + h );
// Salida
Console.WriteLine($":: El resultado de area es: {area}");
Console.WriteLine($":: El resultado de perimetro es: {perimetro}");
// Fin
