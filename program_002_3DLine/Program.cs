// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// N-мерное пространство
int N = 3;

int[] A = new int[N];
int[] B = new int[N];

//вводим значения первой точки
Console.WriteLine("Введите координаты первой точки");
for (int index =0;index < N; index++)
{
    Console.Write($"Введите {index+1}-ю координату ");
    A[index] = Convert.ToInt32(Console.ReadLine());
}

//вводим значения второй точки
Console.WriteLine("Введите координаты второй точки");
for (int index = 0;index < N; index++)
{
    Console.Write($"Введите {index+1}-ю координату ");
    B[index] = Convert.ToInt32(Console.ReadLine());
}

//находим сумму длин квадратов координат по каждой из осей простарнства
int sum_sqr = 0;
for (int index = 0;index < N; index++)
{
    sum_sqr += (B[index] - A[index]) * (B[index] - A[index]);
}
//вычисляем расстояние между точками, извелякая корень из суммы длин квадратов координат
double distance = Math.Sqrt(sum_sqr);
Console.WriteLine($"Расстояние между двумя заданными точками в 3D пространтсве - {distance}");