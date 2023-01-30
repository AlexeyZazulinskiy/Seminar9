/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());


int RecA (int m, int n){
    if (m == 0) 
        return n+1;
    if (m>0 && n==0)
       return RecA(m-1,1);
    if (m>0 && n>0)
        return RecA(m-1 , RecA(m, n-1));
    return 1;
}
Console.Write(RecA(n,m));