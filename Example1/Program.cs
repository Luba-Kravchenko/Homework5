/* Задайте массив заполненный случайными положительными трёхзначными числами.
   Напишите программу, которая покажет количество чётных чисел в массиве. */

class Program
{
    static void WriteArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static int QuantityPositive(int[] array)
    {
        int quantity = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                quantity++;
            }
        }
        return quantity;
    }
    static void Main(string[] args)
    {
        int[] array = new int[0];
        while (true)
        {
            Console.WriteLine("Введите трёхзначные числа массива ");
            string meaning = Console.ReadLine();
            if (meaning != "end")
            {
                int number = Convert.ToInt32(meaning);
                int[] newArray = array;
                array = new int[array.Length + 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    array[i] = newArray[i];
                }
                array[array.Length - 1] = number;
            }
            else
            {
                break;
            }

        }
        WriteArray(array);
        Console.WriteLine();
        int quantity = QuantityPositive(array);
        Console.WriteLine("Количество четных чисел в массиве: " + quantity);

    }
}
