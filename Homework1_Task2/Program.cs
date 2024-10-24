// Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).
// Пример использования: На входе:
// ● a: 5
// ● b: 3
// ● c: 8
// На выходе:
// ● 5
// На входе:
// ● a: 1
// ● b: 9
// ● c: 7
// На выходе:
// ● 7


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if ((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
{
return num1;
}
else if ((num2 >= num1 && num2 <= num3) || (num2 >= num3 && num2 <= num1))
{
return num2;
}
else
{
return num3;
}