string[] GivenArray = new string[] { "123", "23", "hello", "world", "res", "checklength", "=)" };


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

int lengthLimit = GetNumber("Введите длину-ограничитель элемента массива");
int ShortArrayLength = ElementsQuantity(GivenArray, lengthLimit);