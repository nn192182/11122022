// Задайте значение N. Напишите программу, которая выведет все натуральные натуральные числа
// в промежуток от 1 до
/*
void ShowNumbers(int n)
{
    Console.Write(n+ " ");
    if (n>1) ShowNumbers(n-1);
    
}

ShowNumbers (3);

//(3) -> 3>1? y -> (3-1 = 2) -> 2>1? y -> (2-1 = 1) 1>1? n -> CW 1 2 3
//(3) CW 3 3>1? y-> (3-1=2) CW 2 2>1? y -> (2-1 = 1) CW 1>1n
*/

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumDigits (int num)
{
    if (num < 0) num *=(-1);
    if (num > 0) return SumDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine("Input num: ");
int number = Convert.ToInt32 (Console.ReadLine());

int result = SumDigits  (number);
Console.WriteLine (result);
*/

//Задайте значения M и N . Наишите программу, которая выведет все натуральные числа в 
//промежутке от M до N.

// N < N, N = M, M < N
// N = 3 , M = 9 -> 3 4 5 6 7 8 9 
// N = 8, M = 4 -> 4 5 6 7 8 
/*
void ShowNumbersMN(int n, int m)
{
    
    if (Math.Max(n,m) != Math.Min(n,m)) ShowNumbersMN (Math.Max(n,m)-1, Math.Min(n,m));
    Console.Write ($"{Math.Max(n,m) } ");

//Math.Max(n,m) Math.Min(n,m) 

}    

ShowNumbersMN(8,5);
*/
//Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в степень В с помощью рекурсии.
// 2^(-1) =1/2
//2^(-3) = 1/(2^3)  2^3 =8  2^0 = 1
//-2^(-3) =-1/(2^3) -2^3 = -8  -2^4 = 16
// 2^0 = 1 18888^0 = 1
//d^(-v) = 1/ (d^v)
/*
double APowB (int a, int b)
{
if (b>0) return APowB(a, b-1)*a;
//2^3 : a=2, b=3  ; (2,2) 2>0 y (2,1) 1>0 y (2,0) 0>0 ->1
if (b<0) return APowB (a, b + 1) / a;
 return 1.0;

}
double res = APowB (-2,6);
Console.Write (res);
*/

// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
void ShowNumbersMN(int n, int m)
{
    
    if (Math.Max(n,m) != Math.Min(n,m)) ShowNumbersMN (Math.Max(n,m)-1, Math.Min(n,m));
    Console.Write ($"{Math.Max(n,m) } ");

//Math.Max(n,m) Math.Min(n,m) 

}    
int SumDigits (int M, int N)
{
    if (M < 0) M *=(-1);
    if (N > 0) return  ( N / 10) + M % 10;
    else return 0;
}

Console.WriteLine("Input num M: ");
int M = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Input num N: ");
int N = Convert.ToInt32 (Console.ReadLine());

int result =   (M + N);
Console.WriteLine (result);

void ShowSummMN(int n, int m)
{
    
    if (Math.Max(n,m) != Math.Min(n,m)) SumDigits (Math.Max(n,m)-1, Math.Min(n,m));
    Console.Write ($"{Math.Max(n,m) } ");

//Math.Max(n,m) Math.Min(n,m) 

}    

ShowSummMN(N,M);
*/
/*
//Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers(int n)
{
    Console.Write(n+ " ");
    if (n>1) ShowNumbers(n-1);
    
}

ShowNumbers (5);
*/
//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
void ShowNumbersMN(int n, int m)
{
    
    if (Math.Max(n,m) != Math.Min(n,m)) ShowNumbersMN (Math.Max(n,m)-1, Math.Min(n,m));
    Console.Write ($"{Math.Max(n,m) } ");

//Math.Max(n,m) Math.Min(n,m) 

}    

ShowNumbersMN(1,15);
*/