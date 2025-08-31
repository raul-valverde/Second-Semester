// See https://aka.ms/new-console-template for more information

Console.WriteLine("Programa de la semana");
Console.WriteLine("Ingrese un numero del 1 al 7: ");
string? entrada = Console.ReadLine();
if (!int.TryParse(entrada, out int dia))
{
    Console.WriteLine("Entrada no válida. Debe ingresar un número.");
    return;
}
switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Numero ivalido");
        break;
}
