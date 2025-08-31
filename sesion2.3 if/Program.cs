// See https://aka.ms/new-console-template for more information

int calificacion; 
Console.WriteLine("Programa para saber la clasificacion de tu calificacion");
Console.WriteLine("Ingresa tu calificacion: ");
calificacion= Convert.ToInt32(Console.ReadLine());
if (calificacion >= 70 && calificacion <=100)
{
    Console.WriteLine("Aprobaste!");
}
else if (calificacion >= 50 && calificacion <= 69)
{
    Console.WriteLine("Recuperacion");
}
else if (calificacion <50 && calificacion >=0)
{
    Console.WriteLine("Reprobaste");
}
else
{
    Console.WriteLine("Calificacion invalida");
}