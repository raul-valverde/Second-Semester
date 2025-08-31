//Crea un programa que sume los numeros pares e impares del 1 al 100 y muestre los resultados en pantalla.
int i, sumaPares = 0, sumaImpares = 0;
for (i = 1; i <= 100; i + 2)
{
    sumaImpares = sumaImpares + i;
}
Console.WriteLine("La suma de los numeros impares es: " + sumaImpares);
for (i = 2; i <= 100; i + 2)
{
    sumaPares = sumaPares + i;
}
Console.WriteLine("La suma de los numeros pares es: " + sumaPares);