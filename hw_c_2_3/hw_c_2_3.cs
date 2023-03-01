//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

string s_n_1 = Console.ReadLine()!;

int n_1 = int.Parse(s_n_1);

if ((n_1 >= 1) && (n_1 <= 5)) {
    Console.WriteLine("Будний день!");
}else if (n_1 > 7){
    Console.WriteLine("В неделе всего 7 дней");
}else{
    Console.WriteLine("Выходной");
}