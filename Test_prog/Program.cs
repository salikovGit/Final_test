string[] array1 = new string[4] { "NY", "London", "Moscow", "LA" };
string[] array2 = new string[array1.Length];
void ArrayLength(string[] array1, string[] array2)
{
    int i = 0;
    for (int j = 0; j < array1.Length; j++)
    {
        if (array1[j].Length <= 3)
        {
            array2[i] = array1[j];
            i++;
        }
    }
}

ArrayLength(array1, array2);
Console.Write("Initial array: ");
Console.WriteLine(string.Join(" ", array1));
Console.Write("Result array: ");
Console.WriteLine(string.Join(" ", array2));
