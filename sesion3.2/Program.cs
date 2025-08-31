//Crea un programa que lea numeros ingresados y muestre cual es el mayor y el menor. El programa finaliza cuando se ingresa un -99 con while.
int numero;
int mayor = int.MinValue;
int menor = int.MaxValue;
do
{
    console.WriteLine("Ingrese un numero (-99 para finalizar): ");
    numero = convert.toint32(console.readline());
    if (numero != -99)
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
} while (numero != -99);
console.writeline("El numero mayor es: " + mayor);
console.writeline("El numero menor es: " + menor);