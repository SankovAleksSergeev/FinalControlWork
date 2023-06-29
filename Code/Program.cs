Console.Clear();
System.Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. ");
System.Console.WriteLine("Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. ");
System.Console.WriteLine("При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.");

System.Console.WriteLine();
System.Console.Write("Введите размер строкового массива > ");
int ArraySize = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число ограничивающее выборку в массиве > ");
int number = Convert.ToInt32(Console.ReadLine());

string [] Array = new string [ArraySize];

void ArrayFilling (string [] Array)
{
    System.Console.WriteLine($"Введите {ArraySize} элемента(ов) массива");
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = System.Console.ReadLine();
    }
}

int ArrayCheck (string [] Massiv)
{
    int count = 0;
    for (int i = 0; i < Massiv.Length; i++)
    {
        if (Massiv[i].Length <= number)
        {
            count++;   
        } 
    }
    return count;
}

void NewArray (int count, string [] Massiv)
{
    int x = 0;
    string [] NewArray = new string [count];
    System.Console.WriteLine();
    System.Console.WriteLine("Выборка из массива:");
    Console.Write("[ ");
    for (int i = 0; i < Massiv.Length; i++)
    {
        if (Massiv[i].Length <= number)
        {
            NewArray[x] = Massiv[i];       
            System.Console.Write($"'{NewArray[x]}' ");
            x++;
        }
    }
    System.Console.Write("]");
}

ArrayFilling(Array);
int count = ArrayCheck(Array);
NewArray (count ,Array);


