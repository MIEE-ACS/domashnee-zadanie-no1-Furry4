using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дано число A. Вычислить A15, используя две вспомогательные 
//переменные и пять операций умножения. Для этого последовательно 
//находить A2, A3, A5, A10, A15. 
//Вывести все найденные степени числа A.

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите числовое значение A : ");
            string Value_A_text = Console.ReadLine();
            Value_A_text = Value_A_text.Replace(".", ",");//смена точки на запятую при вводе с клавиатуры пользователем
            double Value_A = double.Parse(Value_A_text);

            double check = Math.Pow(Value_A, 15);
            double borders_positive = Math.Pow(1.7, 308);
            double borders_negative = Math.Pow(1.7, -308);

            if (check > borders_positive || check < borders_negative)
            {
                Console.WriteLine("Error!\nThe user entered too large (small) number");
            }

            else {
                double Value_B = Math.Round(Value_A * Value_A,3);//где Value_B значение Value_A в степени 2
                Console.WriteLine($"Значение A в степени 2 = {Value_B}");

                double Value_C = Math.Round(Value_A * Value_B,3);//где Value_C значение Value_A в степени 3
                Console.WriteLine($"Значение A в степени 3 = {Value_C}");

                Value_C = Math.Round(Value_C * Value_B,3);//где Value_C значение Value_A в степени 5
                Console.WriteLine($"Значение A в степени 5 = {Value_C}");

                Value_B = Math.Round(Value_C * Value_C,3);//где Value_B значение Value_A в степени 10
                Console.WriteLine($"Значение A в степени 10 = {Value_B}");

                Value_C = Math.Round(Value_B * Value_C,3);//где Value_B значение Value_A в степени 15
                Console.WriteLine($"Значение A в степени 15 = {Value_C}");

            }
            Console.ReadKey();
        }
    }
}