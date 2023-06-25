// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Massive(int quantity)
{
    int[] massive = new int[quantity];
    Random rnd = new Random();
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = rnd.Next(100, 1000);
    }
    return massive;
}

int QuantEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


System.Console.WriteLine("Введите колличество чисел в масиве: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] mass = Massive(num);

System.Console.WriteLine(string.Join("; ", mass));
System.Console.WriteLine($"Колличество четных чисел в массиве: {QuantEven(mass)}");

