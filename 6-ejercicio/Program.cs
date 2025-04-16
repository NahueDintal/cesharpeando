//Hacer un programa que permita ingresar una cantidad de pesos y me
// calcule la cantidad de dólares, euros y reales que equivale dicha
// cantidad ingresada-

// Ingreso
Console.WriteLine(":: Por favor ingrese la cantidad de pesos a calcular");
double pesos = Convert.ToDouble(Console.ReadLine());

double dolares = 1097;
double reales = 194;
double euros = 1302;

// Proceso
double converdolares = dolares * pesos;
double converreales = reales * pesos;
double convereuros = euros * pesos;

// Salida
Console.WriteLine($"\n :: Valor en Dolares {converdolares}, Valor en Reales {converreales}, Valor en Euros {convereuros}");
