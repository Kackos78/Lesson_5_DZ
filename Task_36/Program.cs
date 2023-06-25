// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] MakeRndArr100(int quantity)
{
    int[] arr = new int[quantity];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;

    
}

int SumNotEven(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

System.Console.WriteLine("Введите колличество элементов массива: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] Array = MakeRndArr100(quantity);
System.Console.WriteLine(string.Join("; ", Array));
System.Console.WriteLine($"{SumNotEven(Array)}");
