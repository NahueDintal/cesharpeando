Console.WriteLine(":: Promedio!");

Console.Write(":: Ingresa la cantidad de notas a promediar: ");
int cantidaddeNotas = int.Parse(Console.ReadLine());

double suma = 0;


for (int i = 0; i < cantidaddeNotas; i++)  
{  
    Console.Write($":: Ingresa nota: #{i+1}: ");  
    double nota = double.Parse(Console.ReadLine());
    suma += nota;
}  

double promedio = suma / cantidaddeNotas;
Console.WriteLine($":: El promedio es: {promedio}");
