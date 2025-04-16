//Realizar un programa que permita ingresar la cantidad de alumnos inscriptos de inglés, francés y portugués de un instituto de idiomas y calcular el porcentaje que representa cada uno de ellos.

// Ingreso
Console.WriteLine(":: Ingrese cantidad de alumnos Ingles!");
double ingles = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(":: Ingrese cantidad de alumnos portugués!");
double portugues = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(":: Ingrese cantidad de alumnos Francés!");
double frances = Convert.ToDouble(Console.ReadLine());

// Proceso
double suma = (ingles + portugues + frances);
Console.WriteLine(":: Cantidad de alumnos!");
Console.WriteLine(suma);

// Salida
double porcingles = (ingles/suma)*100;
Console.WriteLine($"\n:: alumnos de ingles {porcingles} %");

double porcportugues = (portugues/suma)*100;
Console.WriteLine($"\n:: alumnos de portugués {porcportugues} %");

double porcfrances = (frances/suma)*100;
Console.WriteLine($"\n:: alumnos de francés {porcfrances} %");
