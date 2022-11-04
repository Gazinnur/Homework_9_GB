//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное Число");
string num = Console.ReadLine();
int length = num.Length;
string text = string.Empty;
if (length == 5)
{
    for (int i = 0; i < length / 2; i++)
    {
        if (num[i] == num[length - 1 - i])
        {
            text = "Число полином";
        }
        else text = "Число НЕ полином"; break;
    }
}
else text = "Число не пятизначное";
Console.WriteLine(text);