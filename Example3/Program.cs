/* Задайте массив вещественных чисел. 
   Найдите разницу между максимальным и минимальным элементов массива. */

class Program
{
    static void WriteArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    static void Main(string[] args)
    {
        double[] array = new double[0];
        while (true)
        {
            Console.WriteLine("Введите значение массива ");
            string meaning = Console.ReadLine();
            if (meaning != "end")
            {
                double number = Convert.ToDouble(meaning);
                double[] newArray = array;
                array = new double[array.Length + 1];
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
        double min = MinElement(array);
        double max = MaxElement(array);
        Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + (max - min));

    }

    static double MinElement(double[] array)
    {
        double min;
        if (array.Length > 0)
            min = array[0];
        else
        {
            Console.WriteLine("Ошибка: указан пустой массив");
            return 0;
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static double MaxElement(double[] array)
    {
        double max;
        if (array.Length > 0)
            max = array[0];
        else
        {
            Console.WriteLine("Ошибка: указан пустой массив");
            return 0;
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
           
        }
         return max;
    }
}