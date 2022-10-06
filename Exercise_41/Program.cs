// Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Clear();
Console.Write("Type a number M: ");
int m = int.Parse(Console.ReadLine()!);
int[] array = new int[m];
FillArray(array);
Console.WriteLine($"{PositiveNumbers(array)} numbers > 0");

void FillArray(int[] array)
{
    int lenght = array.Length;
   
    for (int i=0; i<array.Length; i++)
    {
        array[i]=int.Parse(Console.ReadLine());
        //if (array == "")
        //break;
    }
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
            count++;
    }
    return count;
}