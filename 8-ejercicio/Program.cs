// Ingresar por teclado la cantidad de horas que trabajo un empleado
//durante un mes y el valor de la hora y calcular el salario
//correspondiente. Teniendo en cuenta que si supera las 160 horas
//trabajadas se deberá abonar el doble del valor del precio por hora
// Inicio
Console.Write(":: Ingresa la cantidad de horas del mes!");
Console.Write(":: Ingresa el valor de hora de trabajo!");
// Entrada
double valor = Convert.ToDouble(Console.ReadLine());
double horas = Convert.ToDouble(Console.ReadLine());
// Condicional discriminando la entrada
if (horas >= 160 )
{
  // Proceso
  double totalpordos = horas * valor * 2;
  // Salida
  Console.WriteLine($":: El salario corresponde a superar las 160hs de trabajo mensuales: ${totalpordos}");
} else {
  // Proceso
  double total = horas * valor;
  // Salida
  Console.WriteLine($":: El salario total por la cantidad de horas de es: ${total}");
}
// Fin!
