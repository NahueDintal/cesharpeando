// Realizar un programa que permita ingresar la cantidad de 
// alumnos inscriptos de inglés, francés y portugués de un 
// instituto de idiomas y calcular el porcentaje que representa 
// cada uno de ellos.
// Inicio
// Ingreso
Console.WriteLine(":: Ingrese cantidad de alumnos Ingles!");
int ing = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(":: Ingrese cantidad de alumnos portugués!");
int port = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(":: Ingrese cantidad de alumnos Francés!");
int fra = Convert.ToInt32(Console.ReadLine());
// Proceso
int suma = ( ing + port + fra );
Console.WriteLine(":: Cantidad de alumnos!");
Console.WriteLine(suma);
int porcing = (ing*100)/suma;
int porcport = (port*100)/suma;
int porcfra = (fra*100)/suma;
// Salida
Console.WriteLine($":: alumnos de ingles: {porcing}%");
Console.WriteLine($":: alumnos de portugués: {porcport}%");
Console.WriteLine($":: alumnos de francés: {porcfra}%");
// Fin
