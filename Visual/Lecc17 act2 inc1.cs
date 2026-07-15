internal class Program
{
    private static void Main(string[] args)
    {
        int numeroFila, numeroColumna;

        int[,] matrizIdentidad = new int[4, 4];

        for (numeroFila = 1; numeroFila <= 4; numeroFila++)
        {
            for (numeroColumna = 1; numeroColumna <= 4; numeroColumna++)
            {
                if (numeroFila == numeroColumna)
                {
                    matrizIdentidad[numeroFila - 1, numeroColumna - 1] = 1;
                }
                else
                {
                    matrizIdentidad[numeroFila - 1, numeroColumna - 1] = 0;
                }
            }
        }

        Console.WriteLine("Matriz Identidad");
        for (numeroFila = 1; numeroFila <= 4; numeroFila++)
        {
            for (numeroColumna = 1; numeroColumna <= 4; numeroColumna++)
            {
                Console.Write(matrizIdentidad[numeroFila - 1, numeroColumna - 1] + " ");
            }
            Console.WriteLine();
        }
    }
}