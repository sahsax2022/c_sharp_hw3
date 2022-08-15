// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


bool IsPolyndromNumber(int number) 
{
        int a = number / 10000;
        //Console.WriteLine(a);
        int b = number % 10000 / 1000;
        //Console.WriteLine(b);
        int c = number % 1000 / 100;
        //Console.WriteLine(c);
        int d = number % 100 / 10;        
        //Console.WriteLine(d);
        int e = number % 10;
        //Console.WriteLine(e);      
        return (a == e && b == d);
}

Console.WriteLine("Input 5 caracter number ");
int NewNum = Convert.ToInt32(Console.ReadLine());
bool Res = IsPolyndromNumber(NewNum);

Console.WriteLine(Res);    
  
