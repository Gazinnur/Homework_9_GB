// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Введите координаты первой точки, через запятую");

// ПРОСТАЯ Рабочая схема:
//  int[] A = { 7, -5, 0 };
//  int[] B = { 1, -1, 9 };
// double distance = 0;
// distance = Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[1] - B[1]) + (A[2] - B[2]) * (A[2] - B[2]));
// Console.WriteLine(distance);
//  Рабочая схема co Вводом координат в 3D:
Console.WriteLine("Введите координаты первой точки");
int[] A =new int[100];
int i=0;
for (i=0; i<3; i++)
{int a =Convert.ToInt32(Console.ReadLine());
A[i]=a;
}
Console.WriteLine();
//Console.Write("{0}",A[i]);
Console.WriteLine("Введите координаты второй точки");
int[] B =new int[100];
i=0;
for (i=0; i<3; i++)
{int a =Convert.ToInt32(Console.ReadLine());
B[i]=a;
}
Console.WriteLine();
double distance = 0;
distance = Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[1] - B[1]) + (A[2] - B[2]) * (A[2] - B[2]));
Console.WriteLine(distance);
