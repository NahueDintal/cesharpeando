// Ingresar por teclado la cantidad de horas que trabajo un empleado
//durante un mes y el valor de la hora y calcular el salario
//correspondiente. Teniendo en cuenta que si supera las 160 horas
//trabajadas se deberá abonar el doble del valor del precio por hora

// Ingreso

Console.Write(":: Ingresa la cantidad de horas del mes!");
double horas = Convert.ToDouble(Console.ReadLine());

Console.Write(":: Ingresa el valor de hora de trabajo!");
double valor = Convert.ToDouble(Console.ReadLine());

// Proceso

if (horas >= 160 )
{
  double totalpordos = horas * valor * 2;
  //Salida
  Console.WriteLine($":: El salario es de: ${totalpordos}");
} else {
  double total = horas * valor;
  //Salida
  Console.WriteLine(total);
}

