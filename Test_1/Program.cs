string[] array = new string[]
{"hello", "2", "world", ":-)",
 "1234", "1567", "-2", "computer science",
 "Russia", "Denmark", "Kazan"};
string[] newArray = new string[array.Length];
int size = 3;

ArrayElemetsFiltered(array, newArray);
PrintArray(newArray);

void ArrayElemetsFiltered(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if (firstArray[i].Length <= size)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}