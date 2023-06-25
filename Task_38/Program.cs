// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] MakeRndArr100(int quantity)
{
    double[] arr = new double[quantity];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    return arr;
}

double DiffMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<min)
        {
            min = arr[i];
        }
        if(arr[i]>max)
        {
            max = arr[i];
        }
    }

    return diff = max - min;
}
System.Console.WriteLine("Введиче колличество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

double[] Array = MakeRndArr100(num);
//System.Console.WriteLine(string.Join("; ", Array));
System.Console.WriteLine($"Разница между большим и меньшим элементом массива {string.Join("; ", Array)} = {DiffMinMax(Array)}");
