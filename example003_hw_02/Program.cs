Console.WriteLine("Введите число обозначающий день недели");
int number = Convert.ToInt32(Console.ReadLine());
    if(number == 6 || number == 7)
        {
             Console.WriteLine("Выходной");
        }
         else if(number > 7)
    {
        Console.WriteLine("Вообще не то пальто");
    }
    else 
    {
        Console.WriteLine("Всем на работу");
    }
   
    