internal class Program
{
    private static void Main(string[] args)
    {
        int fila, columna, num, suma;

        int[,] tabla = new int[4, 3];

        // Leer los datos de la matriz
        for (fila = 1; fila <= 4; fila++)
        {
            for (columna = 1; columna <= 3; columna++)
            {
                Console.Write("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
                tabla[fila - 1, columna - 1] = num;
            }
        }

        // Calcular y mostrar la suma de cada fila
        for (fila = 1; fila <= 4; fila++)
        {
            suma = 0;
            for (columna = 1; columna <= 3; columna++)
            {
                suma = suma + tabla[fila - 1, columna - 1];
            }
            Console.WriteLine("La suma de la fila " + fila + " es: " + suma);
        }
    }
}