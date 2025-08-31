// Programa para calcular el volumen de un tanque en metros cúbicos
Console.WriteLine("Ingrese la longitud del tanque en metros:");
int longitud = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese el ancho del tanque en metros:");
int ancho = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese la altura del tanque en metros:");
int altura = int.Parse(Console.ReadLine() ?? "0");
int volumen = longitud * ancho * altura;
Console.WriteLine($"El volumen total de agua es: {volumen} metros cúbicos");
