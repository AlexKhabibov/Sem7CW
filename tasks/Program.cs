// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

/*
int[,] Create2dArray()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of columns: ");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    int [,] created2dArray = new int [userRows, userColumns];

    for (int i = 0; i < userRows; i++)
    {
        for (int j=0; j < userColumns; j++)
        {
            created2dArray[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2dArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); // для перехода на новую строку
    }
    Console.WriteLine(); // для отсупа от массива
}

int [,] new2dArray = Create2dArray();
Print2dArray(new2dArray);
*/

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3 [0,0] [0,1] [0,2] [0,3] 
// 1 2 3 4 [1,0] [1,1] [1,2] [1,3]
// 2 3 4 5

/*
int [,] FillArray ()
{
    int userRows = 3;
    int userColumns = 4;

    int [,] filled2dArray = new int [userRows, userColumns];
    for (int i = 0; i < userRows; i++)
        for (int j = 0; j < userColumns; j++)
            filled2dArray[i,j] = i + j;
    return filled2dArray;
}

void Print2dArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); // для перехода на новую строку
    }
    Console.WriteLine(); // для отсупа от массива
}

int [,] secondTaskArray = FillArray();
Print2dArray(secondTaskArray);
*/

// Задайте двумерный вещественный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

/*
double[,] Create2dArray()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of columns: ");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    double[,] created2dArray = new double[userRows, userColumns];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColumns; j++)
        {
            created2dArray[i, j] = Math.Round((new Random().Next(userMin, userMax + 1) + new Random().NextDouble()), 2);
        }
    }
    return created2dArray;
}

void Print2dArray(double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); // для перехода на новую строку
    }
    Console.WriteLine(); // для отсупа от массива
}

double[,] ModiArray(double[,] arrayStart)
{
    for (int i = 0; i < arrayStart.GetLength(0); i++)
        for (int j = 0; j < arrayStart.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                arrayStart[i, j] = Math.Round(arrayStart[i, j] * arrayStart[i, j], 3);
    return arrayStart;    
}

double [,] thirdTaskArray = Create2dArray();
Print2dArray(thirdTaskArray);
double [,] modiArray = ModiArray(thirdTaskArray);
Print2dArray(modiArray);
*/

// Дан двумерный массив. Вывести на экран:
// а) все элементы пятой строки массива;
// б) все элементы s-го столбца массива.

// Вариант а)

/*
int[,] Create2dArray()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of columns: ");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    int [,] created2dArray = new int [userRows, userColumns];

    for (int i = 0; i < userRows; i++)
    {
        for (int j=0; j < userColumns; j++)
        {
            created2dArray[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2dArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); // для перехода на новую строку
    }
    Console.WriteLine(); // для отсупа от массива
}

int [,] taskArray = Create2dArray();
Print2dArray(taskArray);

void Print5Line (int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[4, j] + " ");
}

Print5Line(taskArray);
*/

// Вариант б)

/*
int[,] Create2dArray()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of columns: ");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    int [,] created2dArray = new int [userRows, userColumns];

    for (int i = 0; i < userRows; i++)
    {
        for (int j=0; j < userColumns; j++)
        {
            created2dArray[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2dArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); // для перехода на новую строку
    }
    Console.WriteLine(); // для отсупа от массива
}

int [,] taskArray = Create2dArray();
Print2dArray(taskArray);

void Print5Line (int [,] array)
{
    Console.Write(" ");
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i, s] + " ");
}

Print5Line(taskArray);
*/

// Дан двумерный массив. Найти:
// а) сумму элементов, расположенных в левом верхнем и правом нижнем углах;
// б) среднее арифметическое элементов, расположенных в четырех углах.

// Вариант (а): [0, 0] + [GetLength(0) - 1; GetLength(1) - 1] 
// Вариант (б): ([0, 0] + [GetLength(0) - 1; GetLength(1) - 1] + [GetLength(0) - 1; 0] + [0; GetLength(1) - 1]) / 4

/*
int[,] Create2dArray()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of columns: ");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    int [,] created2dArray = new int [userRows, userColumns];

    for (int i = 0; i < userRows; i++)
    {
        for (int j=0; j < userColumns; j++)
        {
            created2dArray[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2dArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); // для перехода на новую строку
    }
    Console.WriteLine(); // для отсупа от массива
}

int [,] taskArray = Create2dArray();
Print2dArray(taskArray);

double AvgArray(int [,] array)
{
    double sum = (array[0, 0] 
                + array[(array.GetLength(0) - 1), (array.GetLength(1) - 1)] 
                + array[array.GetLength(0) - 1, 0] 
                + array[0, array.GetLength(1) - 1]) 
                / 4.0;
    return sum;
}

Console.WriteLine (AvgArray(taskArray));
*/