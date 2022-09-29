using static System.Console;
Clear();

Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(ReadLine());
    arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int len = 3;                                    //Размер массива для отбора
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
        pos++;
    }
}

WriteLine();
WriteLine("Массивы с длинной 3 или менее символов:");
PrintArray(arrayFinal);

//|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
//__|___|___|___|___|___|___|__Блок_|___|___|___|___|___|___|___|__
//|___|___|___|___|___|___|Используемых___|___|___|___|___|___|___|
//__|___|___|___|___|___|___|_методов___|___|___|___|___|___|___|__
//|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + " ");
    }
    WriteLine();
}