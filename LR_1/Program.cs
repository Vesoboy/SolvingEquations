// See https://aka.ms/new-console-template for more information
//      ax^2+bx+c=0

using LR_1;

//Вводим переменные
Console.WriteLine("Введите переменную a");
float variable_a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите переменную b");
float variable_b = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите переменную c");
float variable_c = Int32.Parse(Console.ReadLine());

//Объявляем new класс и передаем значения
//далее выводим результат
var solution = new Equation(variable_a, variable_b, variable_c);
Console.WriteLine(solution.Equation_abc());




