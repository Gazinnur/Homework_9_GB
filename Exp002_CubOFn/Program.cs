// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int Cub=-1;
for (int i = 1; i <= Num; i++)
{
    Cub=i*i*i;
    Console.Write($"{Cub}, ");
}
