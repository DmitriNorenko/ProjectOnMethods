using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace projectOnMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void GetQuestionnaire()
        {
            (string Name, string Surname, double Age, bool HavePet, int Pets, int FavColor) user;
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
                GetNicknames(user.Pets);
            }
            else
            {
                user.HavePet = false;
                user.Pets = 0;
            }
            Console.WriteLine("Сколько у вас любимых цветов?");
            user.FavColor = int.Parse(Console.ReadLine());
            GetFavColor(user.FavColor);
            СheckValues(ref user.Age, ref user.Pets, ref user.FavColor);
        }
        static string[] GetNicknames(int pets)
        {
            string[] nicknames = new string[pets];
            for (int i = 0; i < pets; i++)
            {
                nicknames[i] = Console.ReadLine();
            }
            return nicknames;
        }
        static string[] GetFavColor(int NumColor)
        {
            string[] color = new string[NumColor];
            for (int i = 0; i < NumColor; i++)
            {
                color[i] = Console.ReadLine();
            }
            return color;
        }
        static void СheckValues(ref double age, ref int pets, ref int favColor)
        {
            bool CheckVal = true;
            while (CheckVal)
            {
                if (age <= 0)
                {
                    Console.WriteLine("Вы неверно ввели возраст. Введите еще раз: ");
                    age = int.Parse(Console.ReadLine());
                }
                else if (pets < 0)
                {
                    Console.WriteLine("Вы неверно ввели количество питомцев. Введите еще раз: ");
                    pets = int.Parse(Console.ReadLine());
                }
                else if (favColor <= 0)
                {
                    Console.WriteLine("Вы неверно ввели количество цветов. Введите еще раз: ");
                    favColor = int.Parse(Console.ReadLine());
                }
                else 
                {
                    CheckVal = false;
                }
            }
        }
    }
}
