//Ingresar por teclado tres números y calcular
//su promedio.
// Inicio
Console.WriteLine(":: Promedio!");
Console.Write(":: Ingresa las notas a promediar");
Console.WriteLine(":: Ingresa el primer número");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(":: Ingresa el segundo número");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(":: Ingresa el tercer número");
double num3 = Convert.ToDouble(Console.ReadLine());
// Proceso = operación
double promedio = (num1 + num2 + num3)/ 3;
// Salida
Console.WriteLine($":: El promedio es: {promedio}");
// Final
