// Programa simple para calcular la distancia recorrida por un ciclista
Console.WriteLine("Ingrese la velocidad promedio en km/h:");
int velocidad = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese el tiempo recorrido en horas:");
int tiempo = int.Parse(Console.ReadLine() ?? "0");
int distancia = velocidad * tiempo;
Console.WriteLine($"La distancia total recorrida es: {distancia} km");
// Distancia = Velocidad * Tiempo
