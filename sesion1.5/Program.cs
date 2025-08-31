// Programa para calcular la cantidad total de baldes de leche producida en un día
Console.WriteLine("Ingrese el volumen promedio de leche por vaca (en litros):");
int volumenPorVaca = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese el número total de vacas ordeñadas:");
int numeroVacas = int.Parse(Console.ReadLine() ?? "0");
int totalLitros = volumenPorVaca * numeroVacas;
int baldes = totalLitros / 20;
Console.WriteLine($"La cantidad total de baldes de leche producida es: {baldes}");
