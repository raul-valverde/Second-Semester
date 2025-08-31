// Desarrollar un progra,a que calcule el area total en manzanas
//de un terreno rectangular en una finca, donde el usuario
//ingresa la longitud y el ancho en varas
//1 manzana = 1,428.8 varas cuadradas
//utilizando una cantidad fija de 5 varas de ancho y la longitud como entrada

Console.WriteLine("Ingrese el nombre de la Finca: ");
//Solo pediremos el nombre de la finca
string? tempNombreFinca = Console.ReadLine();
string nombreFinca = string.IsNullOrEmpty(tempNombreFinca) ? "Finca Desconocida" : tempNombreFinca;

Console.WriteLine("Ingrese la longitud del terreno en varas: ");
//Pedimos la longitud del terreno
string Longitud = Console.ReadLine() ?? "";
double longitud;
//Validamos que el usuario haya ingresado un valor numérico
while (!double.TryParse(Longitud, out longitud) || longitud <= 0)
{
    Console.WriteLine("Por favor, ingrese un valor numérico válido para la longitud (mayor que 0): ");
    Longitud = Console.ReadLine() ?? "";
}
// Ancho fijo de 5 varas
double ancho = 5.0;

// Calcular el área en varas cuadradas
double areaVaras = longitud * ancho;

// 1 manzana = 1,428.8 varas cuadradas
double areaManzanas = areaVaras / 1428.8;

Console.WriteLine($"\nLa finca '{nombreFinca}' tiene un área de {areaVaras:F2} varas cuadradas, lo que equivale a {areaManzanas:F4} manzanas.");
