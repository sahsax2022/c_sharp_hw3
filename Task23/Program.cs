// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
//Неявно с какого конца, и в тестах тоже, поэтому 3ю с конца вывожу

void ShowCubeNumber(int number) 
{
    int current = 1;
    while(current <= number)
    {
        Console.Write($"{current * current * current}, ");
        current++;
    }
}

Console.WriteLine("Input number ");
int NewNum = Convert.ToInt32(Console.ReadLine());
ShowCubeNumber(NewNum);


