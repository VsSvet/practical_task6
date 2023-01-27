using System;
using static System.Console;

Clear();
Write("Введите M цифр через пробел: ");
int[] array = GetArrayFromString(ReadLine());

WriteLine(GetQuantityPositiveNumbers(array));




int[] GetArrayFromString (string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;

}


int GetQuantityPositiveNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}