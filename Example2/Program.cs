/* Задайте одномерный массив, заполненный случайными числами.
   Найдите сумму элементов, стоящих на нечётных позициях. */

   class Program
{
    static void WriteArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    static void Main(string[] args)
    {
        int[] array = new int[0];
        while (true)
        {
            Console.WriteLine("Введите значение массива ");
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
        int sum = SumElements(array);
        Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);
    
    }
    static int SumElements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + array[i];
            }
        }
        return sum;
    }
}