//Задача 13: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.

using System;

string str_new = Console.ReadLine()!;

int len = str_new.Length;

if (len < 3){
    Console.WriteLine("В строке меньше 3 цифр!");
}else{
    Console.WriteLine($"Третий элемент строки: {str_new[2]}");
}