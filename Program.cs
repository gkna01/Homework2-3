using System;

class LegendaryMatrix
{  
    static float[,] BuildMatrix(int rows, int columns)
    {
        float[,] matrix = new float[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element[{0},{1}]: ", i, j);
                matrix[i, j] = float.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    static float[,] SumMatrices(float[,] matrix1, float[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        float[,] result = new float[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    static float[,] SubtractMatrices(float[,] matrix1, float[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        float[,] result = new float[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }
        
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter an operator (+ or -): ");
            string operation = Console.ReadLine();

            if (operation == "+" || operation == "-")
            {
                Console.Write("Enter the size of the matrix(row): ");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("Enter the size of the matrix(colums): ");
                int columns = int.Parse(Console.ReadLine());

                float[,] matrix1 = BuildMatrix(rows, columns);
                float[,] matrix2 = BuildMatrix(rows, columns);

                if (operation == "+")
                {
                    float[,] result = SumMatrices(matrix1, matrix2);

                    Console.WriteLine("Result:");
                    for (int i = 0; i < result.GetLength(0); i++)
                    {
                        for (int j = 0; j < result.GetLength(1); j++)
                        {
                            Console.Write(result[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (operation == "-")
                {
                    float[,] result = SubtractMatrices(matrix1, matrix2);

                    Console.WriteLine("Result:");
                    for (int i = 0; i < result.GetLength(0); i++)
                    {
                        for (int j = 0; j < result.GetLength(1); j++)
                        {
                            Console.Write(result[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                break;
            }
        }
    }
}
