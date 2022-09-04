// Программа, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N

//принимаем чесло на вход
Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

//объявляем массив
int[] cube = new int[N];

int index = 0;

//заполняем массив значениями кубов индекса каждого элемента от 1 до N
while (index < N)
{
    cube[index] = (index + 1) * (index + 1) * (index + 1);
    //выводим на экран каждый элемент получающегося массива
    Console.Write($"{cube[index]} ");
    index++;
}
Console.WriteLine();