// Найти произведение двух матриц

int [,] CreateMatrix(int length, int wigth)
{
    Random random = new Random();
    int[,] matrix = new int[length,wigth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(1,4);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
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


int[,] MatrixMulti(int[,] matrix, int[,] matrix1, int length)
{
int[,] matrix3 = new int[length, length];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
       int sum =0;
       for (int z = 0; z < matrix.GetLength(1); z++)
       {
        sum+= matrix[j,z] * matrix1[z,j];
       }
       matrix3[i,j]=sum;
    }
}
return matrix3;
}

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return int.Parse (Console.ReadLine());
}

int length = ReadInt("Строки ");
int wigth = ReadInt("Столбцы ");
int length1 = ReadInt("Строки1 ");
int wigth1 = ReadInt("Столбцы1 ");


int[,] matrix= CreateMatrix(length,wigth);
PrintMatrix(matrix);

Console.WriteLine();

int[,] matrix1 = CreateMatrix(length1,wigth1);
PrintMatrix(matrix1);


 
if (matrix.GetLength(1)!=matrix1.GetLength(0))
{
    Console.WriteLine(" количество столбцов 1 матрицы не равно количеству строк 2 матрицы");
}
else
{
int[,] matrix4= MatrixMulti(matrix,matrix,length);
Console.WriteLine();
PrintMatrix(matrix4);
}


