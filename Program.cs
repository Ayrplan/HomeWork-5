Console.Clear(); 
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int n = 0; n < numbers.Length; n++)
// if (numbers[n] % 2 == 0)
// count++;

// Console.WriteLine($"{numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int sum = 0;
// void input_array(int [] array)
// {
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(0, 100); // [0;9]
// }

// void release(int[] array)
// {
// for (int i = 0; i < array.Length; i+=2)
//     sum = sum + array[i];
// Console.Write($"{array.Length} чисел, сумма нечетных элементов = {sum} ");
// }

// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// input_array(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// release(array);


// Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//         {
//             max = numbers[i];
//         }
//     if (numbers[i] < min)
//         {
//             min = numbers[i];
//         }
// }
// Console.WriteLine($"{numbers.Length} чисел. Max = {max}, Min = {min}");
// Console.WriteLine($"Разница между Max и Min = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 10;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + "; ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }