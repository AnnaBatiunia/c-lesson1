// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int A = 5;
int B = 7;
int C = 2;
int d = 10;
int e = -9;
int f = -3;
int max1 = A;
int max2 = C;
int max3 = e;
if (A>max1) max1 = A;
if (B>max1) max1 = B;
if (C>max2) max2 = C;
if (d>max2) max2 = d;
if (e>max3) max3 =d;
if (f>max3) max3=f;
Console.Write ("max1=");
Console.WriteLine (max1);
Console.Write ("max2=");
Console.WriteLine (max2);
Console.Write ("max3=");
Console.WriteLine (max3);