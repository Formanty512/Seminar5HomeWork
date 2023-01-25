// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*void CreateRandomArray(int[] numbers)
{

    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i]=new Random().Next(100, 999);
    }
}

void ShowArray(int[] numbers)
{  
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
} 

int GetEven(int[] numbers)
{   
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i]%2 == 0) 
            {
                count++;
            }
    }
    return count;
}

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateRandomArray(numbers);
Console.WriteLine("Your array is: ");
ShowArray(numbers);

Console.WriteLine($"Your array has {numbers.Length} characters, {GetEven(numbers)} of them is even");
*/


// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*void CreateRandomArray(int[] numbers)
{

    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i]=new Random().Next(1, 100);
    }
}

void ShowArray(int[] numbers)
{  
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
} 

int GetOddPosition(int[] numbers)
{   
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(i%2 != 0) // четная позиция для пользователя - будет считаться нечетной позицией для машины, поэтому пойдем по нечетным индексам
            {
                sum += numbers[i];
            }
    }
    return sum;
}

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateRandomArray(numbers);
Console.WriteLine("Your array is: ");
ShowArray(numbers);

int result = GetOddPosition(numbers);
Console.WriteLine("The sum of odd positions in your array is: " + result);
*/



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76    


        
int FindMinMaxDiff(int[] array)
            {
                int result = 0;
                int min = 0;
                int max = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[min] > array[i])
                        min = i;
                    else if (array[max] < array[i])
                        max = i;
                }
                Console.WriteLine("min value: " + array[min]);
                Console.WriteLine("max value: " + array[max]);
                if (array[min] > array[max])
                    result = array[min] - array[max];
                else if (array[max] > array[min])
                    result = array[max] - array[min];
                return result;
            }
            Console.Write("Input size of array ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.Write("Input min value: ");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input max value: ");
            int Max = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            if (Min > Max)
            {
                temp = Max;
                Max = Min;
                Min = temp;
            }
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(Min, Max);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i] + "\t");
            

            Console.WriteLine("The difference between min and max: " + FindMinMaxDiff(array));

