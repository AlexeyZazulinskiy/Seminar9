/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

Console.Write("Начатьное число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное число: ");
int b = Convert.ToInt32(Console.ReadLine());


int Rec (int a, int b){
    if (b == a) 
        return b;
    return Rec(a , b-1)+b;
}
Console.Write(Rec(a,b));