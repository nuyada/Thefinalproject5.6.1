using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговый_проект_5._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userData = GetUserData();
            ShowGetUserData(userData);
            Console.ReadKey();
        }
        static (string firstName, string lastName, int age, bool hasPet, string[] petNames, string[] favoriteColors) GetUserData()
        {
            Console.WriteLine("Введите ваше имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string lastName = Console.ReadLine();
            int age = GetPositiveNumber("Введите ваш возраст:");
            Console.WriteLine("Есть ли у вас домашние питомцы (да/нет)");
            bool hasPet = Console.ReadLine().ToLower() == "да";
            string[] petNames = null;
            if (hasPet)
            {
                int petCount = GetPositiveNumber("Введите количество питомцев:");
                petNames = GetNamesPet("Введите имя - имена питомцев:", petCount);
            }
            int coutFavColors = GetPositiveNumber("Введите любимые цвета из предложенных:");
            string[] favoriteColors = GetNameColor("Введите название цвета:", coutFavColors);
            return (firstName, lastName, age, hasPet, petNames, favoriteColors);
        }
        static int GetPositiveNumber(string message)
        {
            Console.Write(message);

            while (true)
            {
                string inputnum = Console.ReadLine();
                if (int.TryParse(inputnum, out int num) && num > 0) return num;
                else Console.WriteLine("Вы ввели некоректное число введите еще раз");

            }
        }
        static string[] GetNamesPet(string message, int count)
        {
            Console.WriteLine(message);
            string[] names = new string[count];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            return names;
        }
        static string[] GetNameColor(string message, int count)
        {
            string[] colors = { "Black", "DarkBlue", "DarkGreen", "Gray", "Blue", "Green", "Cyan", "Red", "Yellow", "White" };
            string[] favColors = new string[count];
            for (int i = 0; i < favColors.Length; i++)
            {
                for (int k = 0; k < colors.Length; k++)
                {
                    Console.Write(colors[k] + " ");
                }
                Console.WriteLine($"{message} Писать английскими с заглавной например Red {i + 1}: ");
                while (true)
                {
                    string color = Console.ReadLine();
                    if (colors.Contains(color))
                    {
                        favColors[i] = color;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("неверное имя цвета, введите cнова например Red или Blue");
                    }

                }


            }
            return favColors;
        }
        static void ShowGetUserData((string firstName, string lastName, int age, bool hasPet, string[] petNames, string[] favoriteColors) userData)
        {
            //string colorName = userData.favoriteColors[0];
            // ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
            // Console.BackgroundColor = color;
            for (int i = 0; i < userData.favoriteColors.Length; i++)
            {
                switch (userData.favoriteColors[i])
                {
                    case "Black":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "DarkBlue":
                        Console.BackgroundColor = ConsoleColor.DarkBlue;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "DarkGreen":
                        Console.BackgroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "Gray":
                        Console.BackgroundColor = ConsoleColor.Gray;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "Blue":
                        Console.BackgroundColor = ConsoleColor.Blue;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "Green":
                        Console.BackgroundColor = ConsoleColor.Green;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "Cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "Red":
                        Console.BackgroundColor = ConsoleColor.Red;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "Yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                    case "White":
                        Console.BackgroundColor = ConsoleColor.White;

                        Console.WriteLine($"Имя: {userData.firstName}");
                        Console.WriteLine($"Фамилия: {userData.lastName}");
                        Console.WriteLine($"Возраст: {userData.age}");
                        if (userData.hasPet)
                        {
                            foreach (var name in userData.petNames)
                            {
                                Console.WriteLine($"Кличка питомца {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет домашних питомцев");
                        }
                        foreach (var name in userData.favoriteColors)
                        {
                            Console.WriteLine($"Любимый цвет {name}");
                        }
                        break;
                }
            }

        }


    }
}
