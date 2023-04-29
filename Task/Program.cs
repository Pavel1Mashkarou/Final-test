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
string [] Array2 = CreateArray(len);

PrintArray(Array1);










