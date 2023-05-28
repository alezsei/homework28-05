nt InText(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task19()
{
    int num1 = InText("Введите пятизначное число");
    num1 = Math.Abs(num1);
    if (num1 > 9999 && num1 < 100000)
    {
        if ((num1 / 10000 == num1 % 10) && ((num1 % 100 ) / 10 == num1 / 1000 % 10))
        {
            Console.WriteLine("Палиндром");
        }
        else Console.WriteLine("Не палиндром");
    }
    else Console.WriteLine("Число не пятизначное");
}


void Task21()
{
    int x1 = InText("Введите координату Х первой точки");
    int y1 = InText("Введите координату Y первой точки");
    int z1 = InText("Введите координату Z первой точки");
    int x2 = InText("Введите координату Х второй точки");
    int y2 = InText("Введите координату Y второй точки");
    int z2 = InText("Введите координату Z второй точки");
    Console.WriteLine (Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2-z1,2))),2));

}



void Task23()
{
    int num1 = InText("Введите N");
    int n = Math.Abs(num1);
    
    for(int count = 1; n >= count; count++)
    {
        if (num1 > 0)
        {
            Console.Write( Math.Pow(count,3));
            Console.Write(" ");
        }
        else
        { 
            Console.Write( Math.Pow(count,3)*-1);
            Console.Write(" ");
        }
    }
    if (n==0) Console.Write("Введен 0, попробуйте другое число");
    

}
Console.Clear();
Console.Write("1.Задача 19 ");
Console.Write("2. Задача 21 ");
Console.WriteLine("3. Задача 23");
int task = InText("Введите номер задачи: ");

switch (task)
{
    case 1: 
        Task19();
        break;
    case 2:
        Task21();
        break;
    case 3:
        Task23();
        break;
}


// задачи повышенной сложности 

// Напишите программу, который выводит на консоль таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100

void Rendm ()
{
    int n = new Random().Next(1,101);

    for (int i =1;i<=n;i++)
    {
        for (int count =1;count <=n; count++)
        {
            
            Console.WriteLine($"{count} x {i} = {count*i}");
            
        }

    }

}
Console.Clear();
//Rendm();
//Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9, 
//второй умножает его на любое натуральное число от 2 до 9, первый умножает результат на любое 
//натуральное число от 2 до 9 и т. д. Выигрывает тот, у кого впервые получится число больше 1000. 
//Запрограммировать консольный вариант игры.

void Game()
{
    int point = 1;
    int player = 1;
    int gameover = 0;
    while (point < 1000)
    {
        Console.WriteLine($"{player} игрок введите любое число от 2 до 9");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb > 1 && numb < 10) 
        {
            point = point * numb;
            if (player == 1)
            {
                player = 2;
            }
            else player = 1;

        }
        else if (gameover != 2)
        {
            Console.WriteLine($"{player} игрок вы ввели число не в игровом диапозоне, повторите ввод, после второго непрвавильного ввода победа будет отдана вашему сопернику");
            gameover++;

        }
        if (gameover == 2) break;

        
    }
    if (gameover == 2)
    {
        if (player == 1)
        {
            Console.WriteLine($"{player} проиграл за нарушения правил,победил его соперник ");
            
        }
        else Console.WriteLine($"{player} проиграл за нарушения правил,победил его соперник ");
            
        
    }
    else
    {
        if (player ==1)
        {
            Console.WriteLine($"Ура!!!! 2 игрок победил, набрав {point} очков ");
        }
        else Console.WriteLine($"Ура!!!! 1 игрок победил, набрав {point} очков ");
    }


    
    

}
Game();
