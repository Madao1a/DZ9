// Составить частотный словарь элементов двумерного массива
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

int[,] CopyMatrix(int [,] matrix)
{
    int[,] matrix1 = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix1[i,j] = matrix[i,j];
        }
    }
    return matrix1;
}

int[,] matrix1 = CopyMatrix(matrix);
//PrintMatrix (matrix1);


int temp = 0;

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        for (int z = 0; z < matrix1.GetLength(0); z++)
        {
            for (int y = 0; y < matrix1.GetLength(1); y++)
            {
                if (matrix1[i,j]<matrix1[z,y])
                {
                temp=matrix1[i,j];
                matrix1[i,j]=matrix1[z,y];
                matrix1[z,y]=temp;
                }
            }

        }
    }
}


Console.WriteLine();
PrintMatrix(matrix1);


int count = 0;
int flag =0;
int A =0;
int B =0;

for (int i = A; i < matrix1.GetLength(0); i++)
{
    flag=0;
    for (int j = B; j < matrix1.GetLength(1); j++)
    {
        if (flag==1)
        {
        break;
        }  

        for (int z=i; z < matrix1.GetLength(0); z++)
        {
            for (int y = j; y < matrix1.GetLength(1); y++)
            {
                if (matrix1[i,j]==matrix1[z,y])
                {
                    count++;
                    flag=0;
                }

                else
                {
                    flag=1;
                    A=z;
                    B=y+1;
                }
            }   
            if (flag==1)
            {
            break;
            }   
                 
        }
        Console.WriteLine($"{matrix[i,j]} встречается {count} {flag} раз"); 
        if (flag==1)
        {
        break;
        }   
    }
   
}

