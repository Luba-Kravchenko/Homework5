/* Задайте массив вещественных чисел. 
   Найдите разницу между максимальным и минимальным элементов массива. */

/*class Program
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
} */



/* class Program                    //Создаём функцию, которая ищет максимальное число
{
    static int MaxNumberArray(int[] array)

    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            
        }
        return max;
    }
static int MinNumberArray(int[] array)

    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            
        }
        return min;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 4, 5, 6, 2, 721, 67, 16, 1 };
        int max = MaxNumberArray(array);
        int min = MinNumberArray(array);
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(max - min);
    }
} */

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        double min = 0, max = 0;

        Console.WriteLine("Сколько чисел вы хотите ввести?");

        int numberCount = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[numberCount];

        Console.Write("[");

        for (int i = 0; i < numberCount; i++)
        {
            array[i] = rand.NextDouble();
            if (0 == i)
            {
                min = array[i];
                max = array[i];
            }
            Console.Write(array[i]);

            if (i != numberCount - 1)
            {
                Console.Write(", ");
            }
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max) ;
            {
                max = array[i];
            }
        }
        Console.WriteLine("]");
        Console.WriteLine("Разница между max и min " + (max - min));
    }

}
