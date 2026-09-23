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


