using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, начало кода
        {
            Console.WriteLine("Привет! Давай сыграем в игру \"Угадай-ка\"!" +
                "\nВведи максимальное целое число диапазона: ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            int j = maxNumber + 1;

            Random rand = new Random();
            int iiNumber = rand.Next(0, j); // чтобы задать верный диапазон, берем переменную макс.число+1
            int count = 0;


            while (1 == 1) // делаем бесконечную игру
            {
                Console.WriteLine("Введи число: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                count++;

                if (userNumber < iiNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуй еще раз");
                }
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуй еще раз");
                }
                else
                {
                    Console.WriteLine($"Поздравляю, число угадано! Число попыток: {count}");
                    Console.WriteLine("Хочешь сыграть снова? Если да, напиши \"yes\", если нет - нажми Enter: "); // даем игроку выбор : продолжать игру или нет
                    var userChoice = Console.ReadLine();

                    if (userChoice == string.Empty) // пустая строка - и есть нажатие кнопки "Еnter"
                    {
                        Console.WriteLine($"Спасибо за игру! Предыдущее число было отгадано за {count} попыток");
                        Console.ReadKey();
                        break;
                    }
                    
                    Console.ReadKey();

                }
            }

            
        }
    }
}
