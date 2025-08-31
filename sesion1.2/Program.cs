// Programa simple para calcular el tiempo de viaje en bus de Managua a Granada
// Distancia fija: 40 km

Console.WriteLine("Ingrese la velocidad promedio en km/h:");
int velocidad = int.Parse(Console.ReadLine() ?? "0");
int distancia = 40;
double tiempo = distancia / velocidad;
Console.WriteLine($"El tiempo total de viaje es: {tiempo} horas");
