// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

int num;
Console.WriteLine("Programa para saber si un numero es positivo, negativo o cero");
Console.WriteLine("Ingresa un numero:");
num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("Numero positivo");
}
else
{
    Console.WriteLine("El numero es negativo");
}