// Realizar un programa que permita ingresar la cantidad de 
// alumnos inscriptos de inglés, francés y portugués de un 
// instituto de idiomas y calcular el porcentaje que representa 
// cada uno de ellos.
// Inicio
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
double porcingles = (ingles/suma)*100;
double porcportugues = (portugues/suma)*100;
double porcfrances = (frances/suma)*100;
// Salida
Console.WriteLine($":: alumnos de ingles: {porcingles}%");
Console.WriteLine($":: alumnos de portugués: {porcportugues}%");
Console.WriteLine($":: alumnos de francés: {porcfrances}%");
// Fin
