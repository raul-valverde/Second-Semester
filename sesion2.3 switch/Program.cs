// See https://aka.ms/new-console-template for more information

Console.WriteLine("Programa para calificar tu calificacion");
Console.WriteLine("Ingresa tu calificacion: ");
int calificacion = Convert.ToInt32(Console.ReadLine());
switch (calificacion)
{
    case int n when (n >= 70 && n <= 100):
        Console.WriteLine("Aprobaste!");
        break;
    case int n when (n >= 50 && n <= 69):
        Console.WriteLine("Recuperacion");
        break;
    case int n when (n < 50 && n >= 0):
        Console.WriteLine("Reprobaste.");
        break;
    default:
        Console.WriteLine("Calificacion no valida");
        break;
}
