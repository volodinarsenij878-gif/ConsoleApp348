using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program188
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Класс пожарной опасности (1–5): ");
            if (!int.TryParse(Console.ReadLine(), out int danger) || danger < 1 || danger > 5)
            {
                Console.WriteLine("Неверный класс.");
                return;
            }

            string threat, restrictions;
            switch (danger)
            {
                case 1:
                    threat = "Низкая";
                    restrictions = "Посещение лесов без ограничений.";
                    break;
                case 2:
                    threat = "Умеренная";
                    restrictions = "Рекомендуется соблюдать осторожность, не разводить костры.";
                    break;
                case 3:
                    threat = "Высокая";
                    restrictions = "Ограничено посещение отдельных участков, запрет на открытый огонь.";
                    break;
                case 4:
                    threat = "Очень высокая";
                    restrictions = "Запрещено посещение лесов, кроме спецработ, строгий запрет на огонь.";
                    break;
                case 5:
                    threat = "Чрезвычайная";
                    restrictions = "Полный запрет на посещение лесов, эвакуация при угрозе.";
                    break;
                default:
                    Console.WriteLine("Недопустимый класс.");
                    return;
            }
            Console.WriteLine($"Уровень угрозы: {threat}. Ограничения: {restrictions}");
        }
    }
}
