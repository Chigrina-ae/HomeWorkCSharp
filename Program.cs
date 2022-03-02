// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее,а какое меньшее

 Console.WriteLine ("Введите первое число");

int ferst = Convert.ToInt32 (Console.ReadLine()); // число 1. Конвертируем текст в число

Console.WriteLine ("Введите второе число");

int second = Convert.ToInt32 (Console.ReadLine());  // число 2. Конвертируем текст в число

if (ferst==second) 
     {Console.WriteLine ($"Числа равны = {ferst}");
     }

else if (ferst>second)
     {Console.Write ($"Наибольшее из чисел - первое = {ferst}");
     }

else
 {Console.Write ($"Наибольшее из чисел - второе = {second}");}


// Задача 4_(решение 1). Напишите программу, которая принимает на вход три числа и выдаетмаксимальное из этих чисел

Console.WriteLine ("Введите первое число");

int ferst = Convert.ToInt32 (Console.ReadLine()); // число 1. Конвертируем текст в число

Console.WriteLine ("Введите второе число");

int second = Convert.ToInt32 (Console.ReadLine());  // число 2. Конвертируем текст в число

Console.WriteLine ("Введите третье число");

int third = Convert.ToInt32 (Console.ReadLine());  // число 3. Конвертируем текст в число

int max = 0;


if (max< ferst)
  {max = ferst;
  }

if (max< second)
  {max = second;
  }
  
if (max< third)
  {max = third;
  }

Console.WriteLine ($"Наибольшее число из трех = {max}");


//  // Задача 4_(решение 2). Напишите программу, которая принимает на вход три числа и выдаетмаксимальное из этих чисел

Console.WriteLine ("Введите 3 числа для сравнения");
 
 int [] numbers = new int [3];
 
 //заполняем массив

numbers [0] = Convert.ToInt32 (Console.ReadLine());
numbers [1] = Convert.ToInt32 (Console.ReadLine());
numbers [2] = Convert.ToInt32 (Console.ReadLine());

int i = 0;
int max = numbers[0];

while (i<3) 
  {if (max<numbers[i])
         {max =numbers[i];
         
         }
     
         
  i=i+1;   
  }


Console.WriteLine ($"Наибольшее число из трех = {max}");




// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без осатка)

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N