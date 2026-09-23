// Funcion de imrpesion de notas
static void ImprimirNotas(int[]notasx)
{
    for (int i=0;i<notasx.Length;i++)
    {
        Console.WriteLine($"Nota {i+1}: {notasx[i]}");
    }
}
//Funcion de promedio de notas
static double PromedioNotas(int[] notasx)
{
    int suma = 0;
    for (int i=0;i<notasx.Length;i++)
    {
        suma += notasx[i];
    }
    return (double)suma /notasx.Length;
}
int[] notas = {15,18,12,17,20};

//imprimir el arreglo de notas
ImprimirNotas(notas);

//promedio de las notas
double promedio = PromedioNotas(notas);
Console.WriteLine($"Promedio de las notas: {promedio:f2}");


//imprimir minimos y maximos de notas
int min = notas[0];
int max = notas[0];
for (int i=1; i < notas.Length;i++)
{
    if (notas[i] < min)
    {
        min = notas[i];
    }
    if (notas[i] > max)
    {
        max = notas[i];
    }
}
Console.WriteLine($"Mínima Nota: {min}");
Console.WriteLine($"Máxima Nota: {max}");