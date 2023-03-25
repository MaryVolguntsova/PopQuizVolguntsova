// Напишите программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

void PrintData(string line)
{
    Console.Write(line);
}
string ReadData(string line)
{
    Console.Write(line);
    return Convert.ToString(Console.ReadLine()??"0");
}
int ReadDataForInt(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine()??"0");
}
void Print1DArray(string[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}
// Просим у пользователя задать массив, чтобы избежать магических чисел. Пусть хоть 100 введет.
int n = ReadDataForInt("Введите желаемую величину массива, который хотите заполнить: ");
// Создадим массив, который хочет пользователь
string[] allThatYouWant = new string[n];
// Пусть пользователь задаст аргументы массива, для этого используем цикл
for(int i = 0; i < allThatYouWant.Length; i++)
{
    allThatYouWant[i] = ReadData("Введите значение: ");
}
// Выводим получившийся массив
PrintData("Вы ввели массив: ");
Print1DArray(allThatYouWant);
// Напишем метод выборки аргументов массива, которые соответвуют условию. Формат string, тк возвращается тоже массив
string[] LookingForThreeChars(string[] arr)
{
    // Создаем список, в котором будем хранить значения, соотв. условию
    List<string> newResult = new List<string>();
    // Идем по старому массиву
    for(int i = 0; i < arr.Length; i++)
    {
            // Узнаем количество знаков с помощью свойства Length;
            int size = arr[i].Length;
            // Проверяем на условие
            if(size <= 3) newResult.Add(arr[i]);
    }
    // Преобразуем список в массив
    string[] result = newResult.ToArray();
    return result;
}

string[] arrWithThreeChars = LookingForThreeChars(allThatYouWant);
PrintData("Результат программы: ");
Print1DArray(arrWithThreeChars);