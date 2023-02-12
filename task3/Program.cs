// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] CreatreMatrix(int length, int wigth)
{
    int[,] matrix = new int[length,wigth];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(1,6);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string massage)
{
    Console.WriteLine (massage);
    return int.Parse (Console.ReadLine());
}

int length = ReadInt("Строки ");
int wigth = ReadInt("Столбцы ");

int[,] matrix = CreatreMatrix(length,wigth);
PrintMatrix (matrix);

int min= matrix[0,0];
int A=0;
int B=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1)-1; j++)
    {
        if (matrix[i,j]<min)
        {
        min=matrix[i,j];
        A=i;
        B=j;
        }
    }
}
Console.WriteLine();
Console.WriteLine(min);
Console.WriteLine(A);
Console.WriteLine(B);

int k=0;
int l=0;
int[,] NewDeleteMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i!=A&&j!=B)
        {
            NewDeleteMatrix[k,l]=matrix[i,j];
            l++;
        }
    }
    l=0;
    if (A!=i)
    {
        k++;
    }
}

Console.WriteLine();
PrintMatrix(NewDeleteMatrix);

