// // Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
// int num = new Random().Next(10,100);
// Console.WriteLine(num);
// int first_num = num / 10 ;
// int second_num = num % 10;
// if (first_num > second_num)
// {
//     Console.WriteLine(first_num);
// }
// else
// {
//     Console.WriteLine(second_num);
// }


// // 2.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// //456 -> 46 782 -> 72 918 -> 98

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int first_num = num / 100 ;
// int second_num = num % 10;
// int new_num = (first_num*10) + second_num;
// Console.WriteLine(new_num);


// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно


// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse (Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse (Console.ReadLine());

// if ( num1 % num2 ==0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     int remains = num1 % num2;
//     Console.WriteLine("Остаток ");
//     Console.Write(remains);
// }

//4.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
//14 -> нет 46 -> нет 161 -> да
// Console.WriteLine("Введите число: ");
// int num = int.Parse (Console.ReadLine());
// if (num % 7 ==0 & num % 23 ==0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


//5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

// Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse (Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse (Console.ReadLine());

// if(num1 == num2 * num2 | num2 == num1 *num1)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
