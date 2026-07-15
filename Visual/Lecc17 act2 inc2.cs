internal class Program
{
    private static void Main(string[] args)
    {
        int numeroFila, numeroColumna;

        int[,] matrizColumnas = new int[4, 4];

        for (numeroFila = 1; numeroFila <= 4; numeroFila++)
        {
            for (numeroColumna = 1; numeroColumna <= 4; numeroColumna++)
            {
                matrizColumnas[numeroFila - 1, numeroColumna - 1] = numeroColumna;
            }
        }

        Console.WriteLine("Matriz de Columnas");
        for (numeroFila = 1; numeroFila <= 4; numeroFila++)
        {
            for (numeroColumna = 1; numeroColumna <= 4; numeroColumna++)
            {
                Console.Write(matrizColumnas[numeroFila - 1, numeroColumna - 1] + " ");
            }
            Console.WriteLine();
        }
    }
}
