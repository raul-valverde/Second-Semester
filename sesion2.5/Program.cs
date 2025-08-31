// See https://aka.ms/new-console-template for more information

Console.WriteLine("Programa para saber si un año es bisiesto");
Console.WriteLine("Escriba el año: ");
int anio = Convert.ToInt32(Console.ReadLine());
if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))
{
    Console.WriteLine("El año " + anio + " es bisiesto");
}
else
{
    Console.WriteLine("El año " + anio + " no es bisiesto");
}
