//Логические выражения среддний уровень №18
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//double discount;
//if (x >= 1000 && x < 2000)
//    discount = 0.05;
//else if (x >= 2000 && x <5000)
//    discount = 0.1;
//else
//    discount = 0.0;
//Console.WriteLine($"Стоимость покупки{discount}");

//Условные операторы сложный уровень №12
Console.Write("Введите х:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
if (y < 2 - x * x && y > -2)
{
    Console.WriteLine("Лежит");
}    
    
else
{
        Console.WriteLine("Не лежит");
}
