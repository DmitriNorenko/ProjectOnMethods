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
            ShowQuestionnaire();
            Console.ReadKey();
        }
        static (string, string, double, bool, int, int, string[], string[]) GetQuestionnaire()
        {
            (string Name, string Surname, double Age, bool HavePet, int Pets, int FavColor, string[] NickPets, string[] Colors) user;
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
                user.NickPets = GetNicknames(user.Pets);
            }
            else
            {
                user.HavePet = false;
                user.Pets = 0;
                user.NickPets = GetNicknames(user.Pets);
            }
            Console.WriteLine("Сколько у вас любимых цветов?");
            user.FavColor = int.Parse(Console.ReadLine());
            user.Colors = GetFavColor(user.FavColor);
            СheckValues(ref user.Age, ref user.Pets, ref user.FavColor);
            return user;

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
        static void ShowQuestionnaire()
        {
            var User = GetQuestionnaire();
            (string name, string surName, double age, bool havePet, int pets, int favColor, string[] nickPets, string[] colors) = User;
            Console.WriteLine("Вас зовут : {0}", name);
            Console.WriteLine("Ваша фамилия : {0}", surName);
            Console.WriteLine("Ваш возраст: {0}", age);
            if (havePet == true)
            {
                Console.WriteLine("У вас домашних питомцев: {0}", pets);
                Console.WriteLine("Клички ваших питомцев: ");
                foreach (var pet in nickPets)
                {
                    Console.WriteLine(pet);
                }
            }
            Console.WriteLine("У вас  любимых цветов:{0}",favColor);
            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
