using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOnMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void GetQuestionnaire()
        {
            (string Name, string Surname, double Age, bool HavePet, int Pets) user;
            Console.WriteLine("Введите имя: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            user.Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            user.Age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Есть питомец? ");
            if (Console.ReadLine() == "да")
            {
                user.HavePet = true;
                Console.WriteLine("Сколько у вас питомцев? ");
                user.Pets = int.Parse(Console.ReadLine());
            }
            else
            {
                user.HavePet = false;
            }
        }
    }
}
