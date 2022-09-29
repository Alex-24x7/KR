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
int len = 3;
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
PrintArray(arrayFinal);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + " ");
    }
    WriteLine();
}