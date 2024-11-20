// Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

// Пример

// [1 3 5 6 7 8] => [8 7 6 5 3 1]

int[] array = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
int temp;

// Вывод исходного массива
Console.Write("Исходный массив: ");
foreach (int number in array)
{
    Console.Write(number + " ");
}
// Реверсирование массива
for (int i = 0; i < array.Length / 2; i++)
{
    // Меняем местами элементы
    temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
// Вывод измененного массива
Console.Write("\nПеревернутый массив: ");
foreach (int number in array)
{
Console.Write(number + " ");
}