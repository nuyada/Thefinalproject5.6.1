﻿using System;
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
        /// <summary>
        /// Метод для добавления информации в кортеж
        /// </summary>
        /// <returns></returns>
        static (string firstName, string lastName, int age, bool hasPet, string[] petNames, string[] favoriteColors) GetUserData()
        {
            Console.WriteLine("Введите ваше имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string lastName = Console.ReadLine();
            int age = GetPositiveNumber("Введите ваш возраст:");
            Console.WriteLine("Есть ли у вас домашние питомцы (да/нет)");
            bool hasPet =  Console.ReadLine().ToLower() == "да";
            string[] petNames = null;
            if (hasPet)
            {
                int petCount = GetPositiveNumber("Введите количество питомцев:");
                petNames = GetNamesPet("Введите имя - имена питомцев:", petCount);
            }
            int coutFavColors = GetPositiveNumber("Введите количество любимых цветов:");
            string[] favoriteColors = GetNameColor("Введите название цвета:", coutFavColors);
            return (firstName, lastName, age, hasPet, petNames, favoriteColors);
        }
        /// <summary>
        /// Метод для проверки введного числа
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static int GetPositiveNumber( string message)
        {
            Console.Write(message);
            
            while (true)
            {
                string inputnum = Console.ReadLine();
                if (int.TryParse(inputnum, out int num) && num > 0) return num;
                else Console.WriteLine("Вы ввели некоректное число введите еще раз");

            }
        }
        /// <summary>
        /// Метод для добавления в массив кличек питомцев
        /// </summary>
        /// <param name="message"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        static string[] GetNamesPet(string message, int count )
        {
            Console.WriteLine(message);
            string[] names = new string[count];
            for(int i =0; i< names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            return names;
        }
        /// <summary>
        /// Метод для добавления в массив любимых цветов
        /// </summary>
        /// <param name="message"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        static string[] GetNameColor(string message, int count)
        {
            string[] favColors = new string[count];
            for (int i = 0; i < favColors.Length; i++)
            {
                Console.WriteLine($"{message}  {i + 1}: ");
                
                favColors[i] = Console.ReadLine();
                
            }
            return favColors;
        }
        /// <summary>
        /// Метод для отображения информаии кортежа 
        /// </summary>
        /// <param name="userData"></param>
        static void ShowGetUserData((string firstName, string lastName, int age, bool hasPet, string[] petNames, string[] favoriteColors) userData)
        {
            
            
            Console.WriteLine($"Имя: {userData.firstName}");
            Console.WriteLine($"Фамилия: {userData.lastName}");
            Console.WriteLine($"Возраст: {userData.age}");
            if (userData.hasPet)
            {
                foreach(var name in userData.petNames)
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
        }


    }
}
