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

//funcion de nota maxima
static int notamaxima(int[] notasx)
{
    int max = notasx[0];
    for (int i=1;i< notasx.Length;i++)
    {
        if (notasx[i]> max)
        {
            max = notasx[i];
        }
    }
    return max;
}
//funcion de notas minimo
static int NotaMinima(int[]notasx)
{
    int min = notasx[0];
    for (int i = 1;i < notasx.Length;i++)
    {
        if (notasx[i] < min)
        {
            min = notasx[i];
        }
    }
    return min;
}
int[] notas = {15,18,12,17,20};

//imprimir el arreglo de notas
ImprimirNotas(notas);

//promedio de las notas
double promedio = PromedioNotas(notas);
Console.WriteLine($"Promedio de las notas: {promedio:f2}");


//imprimir minimos y maximos de notas
int maxima = notamaxima(notas);
int minimo = NotaMinima(notas);
Console.WriteLine($"Mínima Nota: {minimo}");
Console.WriteLine($"Máxima Nota: {maxima}");