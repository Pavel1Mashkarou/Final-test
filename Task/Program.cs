string[] CreateArray(int Length)
{
    string [] Array = new string [Length];
    for (int i = 0; i < Length; i++)
    {
        Array[i] = Console.ReadLine();
    }
    return Array;
}

System.Console.WriteLine("Введите количество элементов в массиве:");
int len = int.Parse(Console.ReadLine());

string [] Array1 = CreateArray(len);
string [] Array2 = new string [Array1.Length];

System.Console.WriteLine("Задан массив:");
PrintArray(Array1);

void FilterArray(string[] Array1, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
    if(Array1[i].Length <= 3)
        {
        Array2[count] = Array1[i];
        count++;
        }
    }
}
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}
FilterArray(Array1, Array2);
System.Console.WriteLine("Изменённый массив:");
PrintArray(Array2);









