// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] CreateRandomArray(int N )   // 2. присваиваем переменной N значение 8
{
    int[] RandomArray = new int[N];  // 3.Задаем массив в котором будут лежать значения, и определяем его длину. метод new - выделение динамической памяти
    for (int i = 0; i < N; i++)   // 4.цикл. обрабатывает значения от i < N
    {
        RandomArray[i] = new Random().Next();  // 5.Заполняем массив при помощи метода new Random() 
    }
    return RandomArray; // 6.возвращяем заполненный масссив RandomArray
}

void ShowArray(int[] array) // 8.Функция вывода на экран массив RandomArray[i]
{
    for (int i = 0; i < array.Length; i++)  // 9. цикл. обрабатывает значения от i до длины массива int[] array и RandomArray[i]
    {
        Console.Write(array[i] + " ");  // 10. выводим на экран массив RandomArray[i]
    }
    Console.WriteLine();
} 

int[] myRandomArray = CreateRandomArray(8); // 1. Присваиваем масиву длину из 8ми элементов и прираниваем масиву int[] myRandomArray
ShowArray(myRandomArray); // 7. Присваиваем переменной myRandomArray значение массива RandomArray
