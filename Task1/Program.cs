// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


void GetNaturalDegree(int number, int numbers)   //6. начало функции
{

    int NaturalDegree = 0;     //7. вводим переменную NaturalDegree в которую будем складывать значени
    for (int i = 1; i <= numbers; i++)  //8. Цикл проходит numbers и b раз пока i не будет равна numbers и b
    {
        NaturalDegree = i * number;  //9. переможаем значение i с number и присваиваем полученое значение в переменную NaturalDegree
    } 
    Console.WriteLine($"число в натуральной степени : {NaturalDegree}"); //10. выводим на экран.
}

Console.Clear();

Console.WriteLine("Введите число A");   //1.просим ввести значение А
int a = Convert.ToInt32(Console.ReadLine());   //2. инициализируем, присваиваем введёному значению переменную a

Console.WriteLine("Введите число Б");   //3.просим ввести значение Б
int b = Convert.ToInt32(Console.ReadLine()); //4. инициализируем, присваиваем введёному значению переменную b


GetNaturalDegree(a,b);//5. присваиваем int number, int numbers значения a и b