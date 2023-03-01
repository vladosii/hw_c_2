//Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.

using System;

string str_new = Console.ReadLine()!;

int len = str_new.Length;

if (len < 3){
    Console.WriteLine("В строке меньше 3 цифр!");
}else{
    Console.WriteLine($"Второй элемент строки: {str_new[1]}");
}