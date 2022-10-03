using System;
using System.Collections.Generic;


{
    int first, second, third, quatro;
    Console.WriteLine("Введите число n:");
    first = Convert.ToInt32(Console.ReadLine());
    second = (first / 100);
    third = (first % 100);
    quatro = ((third * 10) + second);



    Console.WriteLine("Ответ:{0}", quatro);
    Console.ReadKey();

}



//2.25)Из трехзначного числа x вычли его последнюю цифру.
//Когда результат разделили на 10, а к частному слева
//приписали последнюю цифру числа x, то получилось
//число n. Найти число n. По заданному n найти число x
//(значение n вводится с клавиатуры, 10≤n ≤999 и при
//этом число десятков в n не равно нулю).