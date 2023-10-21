// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string msg) // функция считывания с консоли
{
    Console.WriteLine(msg); // ввод текста в консоль
    string line = Console.ReadLine (); // вводим переменную типа стринг, которой присваиваем текст из консоли
    int number = int.Parse(line); // вводим переменную типа int и присваиваем ей преобразованную строку в тип int
    return number; // возвращаем преобразованную переменную (наше введенное число)
}
int[] GenerateArray(int length, int MinValue, int MaxValue) // объявление функции для массива с длиной массива Length, мин значением и макс значением
{
int[] myArray = new int[length]; // объявлем пустой массив типа int, 
                                //с названием myarray и присваиваем количество элементов length
Random elements = new Random(); // создание генератора случайных чисел
for (int i=0; i < myArray.Length; i++)  
    {
        myArray[i] = elements.Next(MinValue, MaxValue+1);
    }
return myArray;
}
// Функция вывода массива на экран
void PrintArray(int[] myArray)
{
    Console.Write(myArray[0]); // Вывод первого элемента массива
    for (int i=0; i < myArray.Length; i++)
    {
        System.Console.Write($", {myArray[i]}");  // Вывод текущего элемента массива
    }
    System.Console.WriteLine();  
    
}
Console.WriteLine ($"Введите минимальное значение массива: ");
int MinValue= int.Parse(Console.ReadLine());
Console.WriteLine ($"Введите максимальное значение массива: ");
int MaxValue = int.Parse(Console.ReadLine());
int[] numbers = GenerateArray(8,MinValue, MaxValue);
PrintArray(numbers);


