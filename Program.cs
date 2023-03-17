﻿string[] GivenArray = new string[] { "123", "23", "hello", "world", "res", "checklength", "=)" };

void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

int ElementsQuantity(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int lengthLimit = GetNumber("Введите длину-ограничитель элемента массива");
int ShortArrayLength = ElementsQuantity(GivenArray, lengthLimit);

string[] newShortArray = new string[ShortArrayLength];

FillNewArray(GivenArray, newShortArray, lengthLimit);
PrintArray(newShortArray);