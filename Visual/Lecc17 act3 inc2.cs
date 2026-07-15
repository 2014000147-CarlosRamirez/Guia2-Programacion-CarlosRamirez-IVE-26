internal class Program
{
    private static void Main(string[] args)
    {
        int fila, columna, x, yy, mayor;

        int[,] tabla = new int[4, 4];

        // Leer los datos de la matriz
        for (fila = 1; fila <= 4; fila++)
        {
            for (columna = 1; columna <= 4; columna++)
            {
                Console.Write("Ingrese un número: ");
                tabla[fila - 1, columna - 1] = int.Parse(Console.ReadLine());
            }
        }

        // Tomar el primer elemento como referencia
        mayor = tabla[0, 0];
        x = 1;
        yy = 1;

        // Buscar el número mayor
        for (fila = 1; fila <= 4; fila++)
        {
            for (columna = 1; columna <= 4; columna++)
            {
                if (tabla[fila - 1, columna - 1] > mayor)
                {
                    mayor = tabla[fila - 1, columna - 1];
                    x = fila;
                    yy = columna;
                }
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("En la fila " + x + ", es: " + mayor);
        Console.WriteLine("Y en la columna: " + yy);
    }
}