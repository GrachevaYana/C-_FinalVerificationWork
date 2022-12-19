//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
//Пример: { "1234", "1567", "-2", ":-)", "computer science","%(" } ->  { "-2", ":-)", "%(" }

string[] arrayfirst = new string[6] { "1234", "1567", "-2", ":-)", "computer science","%(" };
string[] arraysecond = new string[arrayfirst.Length];
void FillArraySecond(string[] arrayfirst, string[] arraysecond)
{
    int count = 0;
    for (int i = 0; i < arrayfirst.Length; i++)
    {
        if (arrayfirst[i].Length <= 3)
        {
            arraysecond[count] = arrayfirst[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{array[i]}");
    }
    Console.WriteLine();
}
FillArraySecond(arrayfirst, arraysecond);
PrintArray(arraysecond);