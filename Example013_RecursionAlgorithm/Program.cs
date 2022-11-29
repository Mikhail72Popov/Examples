//string[,] table = new string[2, 5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
/*
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns <5; columns++)
    {
        Console.WriteLine($"{table[rows, columns]}");
    }

}
*/
/*
int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine($"{matrix[i, j]}"); // получится в один столбик
    }
}
*/
/*
int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]} "); // получится таблица
    }
Console.WriteLine();
}
*/
// или
/*
int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} "); // получится таблица
    }
Console.WriteLine();
}
*/
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        Console.Write($"{matr[i, j]} ");
        }
     Console.WriteLine();
    }
}

// генератор случайных чисел
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); // для прослойки
PrintArray(matrix);
*/
// Факториал
/*
int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i <40; i++)
{
    //Console.WriteLine(Factorial(3)); 
    Console.WriteLine($"{i}!={Factorial(i)}"); //для контроля больших факториалов до 17
}
*/

double Factorial(int n) // для факториалов больше 17
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i <40; i++)
{
    //Console.WriteLine(Factorial(3)); 
    Console.WriteLine($"{i}!={Factorial(i)}");
}

// Фибонaччи
//f(1) = 1
//f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)  // для больших чисел использовать double
{
    if (n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);

}
for (int i=1; i<50; i++)
{
    //Console.WriteLine(Fibonacci(i));
    Console.WriteLine($"f({i}) = {Fibonacci(i)}"); //для контроля больших чисел

}