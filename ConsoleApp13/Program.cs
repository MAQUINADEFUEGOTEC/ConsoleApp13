// See https://aka.ms/new-console-template for more information

using Rastreo_Autos;

Console.WriteLine("-------Auto-------");
int cant, cantGas, cantGaso = 0;
Console.WriteLine("INGRESE LOS DATOS DEL VEHICULO");
Console.WriteLine("Ingresa la cantidad que van al dia");
cant = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la cantidad de vehiculos a Gas");
cantGas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la cantidad de vehiculos a Gasolina");
cantGaso = int.Parse(Console.ReadLine());
Vehiculo auto = new Vehiculo("Tipo vehiculo", 5, cant, cantGas, cantGaso);
Console.WriteLine();



Console.WriteLine("-------Moto-------");
int cantm = 0, cantC250 = 0, cantP = 0;
Console.WriteLine("INGRESE LOS DATOS DE MOTOS");
Console.WriteLine("Ingrese la cantidad que ingresan al dia:");
cantm = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de motos con un cilindraje mayor a 250:");
cantC250 = int.Parse(Console.ReadLine());
Moto moto = new Moto("Tipo Moto", 2, cantm, cantC250);


Console.WriteLine("---------");
auto.mostrarvehiculo();
Console.WriteLine("---------");
moto.mostrarmoto();
cantP = moto.CalcularPer() + auto.CalcularPer();
Console.WriteLine("---------");
Console.WriteLine("Cantidad maxima de personas: " + cantP);