// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//int Exponentiation(int numberA, int numberB)
//{
//    int result=1;
//   int i=1;
//   while  (i<= numberB)
//   {
//       result=result*numberA;
//      i++;
//  }
// return result;
//}

//Console.Write("Введите число А: ");
//int numberA = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число B: ");
//int numberB = Convert.ToInt32(Console.ReadLine());

//int exponentiation = Exponentiation(numberA, numberB);
 // Console.WriteLine($"Результат возведения числа в натуральную степень= {exponentiation}");




//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


//int SumNumber(int numberA)
//{
//   int counter=Convert.ToString(numberA).Length;
//    int temp = 0;
//    int result = 0;
//    int i = 0;
//    while (i< counter)
//    {
//        temp=numberA-numberA%10;
//        result=result+(numberA-temp);
//       numberA=numberA/10;
//        i++;
//    }
//    return result;
// }
// Console.Write("Введите число: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   int sumNumber= SumNumber(numberA);
//Console.WriteLine($"Сумма цифр в заданном числе= {sumNumber} ");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.Write("Введите ряд чисел: ");
string? rangeOfNumbers = Console.ReadLine();
rangeOfNumbers = rangeOfNumbers + ",";


int[] array= ArrayOfNumber(8,0,100);

int[] ArrayOfNumber(int size,int minValue,int maxValue)
{
    
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }

    return result;
}

Console.WriteLine($"Вывод элементов массива на экран=[{rangeOfNumbers}]");
