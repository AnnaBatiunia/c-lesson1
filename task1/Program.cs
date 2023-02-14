// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine ("Введите число 1: ");
int numb1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 2: ");
int numb2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 3: ");
int numb3 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 4: ");
int numb4 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 5: ");
int numb5 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 6: ");
int numb6 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 7: ");
int numb7 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 8: ");
int numb8 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 9: ");
int numb9 = Convert.ToInt32 (Console.ReadLine ());

int max1 = numb1;
int max2 = numb4;
int max3 = numb7;
if (numb1>max1) max1 = numb1;
if (numb2>max1) max1 = numb2;
if (numb3>max1) max1 = numb3;
if (numb4>max2) max2 = numb4;
if (numb5>max2) max2 = numb5;
if (numb6>max2) max2 = numb6;
if (numb7>max3) max3 = numb7;
if (numb8>max3) max3 = numb8;
if (numb9>max3) max3 = numb9;
Console.Write ("max1=");
Console.WriteLine (max1);
Console.Write ("max2=");
Console.WriteLine (max2);
Console.Write ("max3=");
Console.WriteLine (max3);

