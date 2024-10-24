// Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".
// Пример использования: 
// На входе:
// ● firstNumber: 10
// ● secondNumber: 2
// На выходе:
// ● делится
// На входе:
// ● firstNumber: 10
// ● secondNumber: 3
// На выходе:
// ● не делится

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == 0)
{
    Console.WriteLine("На ноль делить нельзя");
}
else if (num1 % num2 == 0)
{
    Console.WriteLine("Делится");
}
else
{
    Console.WriteLine("Не делится");
}
