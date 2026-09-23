// Funcion de imrpesion de notas
static void ImprimirNotas(int[]notasx)
{
    for (int i=0;i<notasx.Length;i++)
    {
        Console.WriteLine($"Nota {i+1}: {notasx[i]}");
    }
}
int[] notas = {15,18,12,17,20};

//imprimir el arreglo de notas
ImprimirNotas(notas);