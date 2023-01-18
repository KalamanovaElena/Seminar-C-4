//Задача 1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write($"Число {A} в степени {B} равно {Exponentiation(A, B)}");

int Exponentiation(int A, int B){
  int result = 1;
  for(int i=1; i <= B; i++){
    result = result * A;
  }
  return result;
}

//Задача 2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр числа {A} равна {GetSum(A)}");

int GetSum (int limit){
    int Sum = 0;
        for(int i = 1; i <= limit; i++){
            Sum += A % 10;
            A /= 10;
        }
    return Sum;
}

//Задача 3 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] Array = GetArray(8);
Console.Write($"[{String.Join(" ", Array)}]");

int[] GetArray (int size){
    int[] Array = new int[size];
    for(int i = 0; i < size; i++){
        Array[i] = new Random().Next();
    }
    return Array;
    }
