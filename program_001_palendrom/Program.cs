// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

//описываем метод возведения числа 10 в степень 
int Ten(int degree)
{   
    int ten_in_degree = 1;
    for (int i = 1; i <= degree;i++)
        {
            ten_in_degree = ten_in_degree * 10;
        }
    return ten_in_degree;
}
//разрядность случайного числа
int N = 5;

//задаем случайное число
Random rnd = new Random();
int Number = rnd.Next(Ten(N-1),Ten(N));

Console.WriteLine($"Задано случайное число - {Number}");

int[] digits = new int[N];

//остаток числа при определении его цифр
int Division = 0;

// определяем цифры числа
for (int index = 0; index < N;index++)
{
    digits[index] = (Number - Division)/Ten(N-index-1);
    Division += digits[index]*Ten(N-index-1);
}

int palendrom = 0;

//проверяем является ли число палендромом попарно сравнивая элементы массива относительно его середины
for (int index = 0; index < N/2; index++)
{
    if (digits[index] == digits[N-index-1]) palendrom ++;
}

if (palendrom == N/2) Console.WriteLine($"Число {Number} является палендромом");
else Console.WriteLine($"Число {Number} не является палендромом");

