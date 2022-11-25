using System;
using System.Collections.Generic;

namespace DataBase
{
    class DataBase
    {
        static List<string> name = new List<string>();
        static List<string> classNumber = new List<string>();
        static bool cycle = true;
        private static void Main()
        {
            
            while (cycle)
            {
                Menu();
            }
            
        }
        static void Menu()
        {
            Console.WriteLine("");
            Console.Write("Журнал");
            Console.WriteLine("\n1 - Показать Журнал" + 
                "\n2 - Добавить информацию об ученике" + 
                "\n3 - Удалить информацию об ученике" + 
                "\n4 - выйти"+
                "\n5 - сортировать по классам");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Show();
                    break;
                case 2:
                    AddInf();
                    break;
                case 3:
                    Remove();
                    break;
                case 4:
                    cycle = false;
                    break;
                case 5:
                    Sort();
                    break;
                default:
                    Console.WriteLine("ошибка");
                    Menu();
                    break;
            }
            
        }

        private static void Remove()
        {
            Console.WriteLine("");
            if (name.Count == 0)
            {
                Console.WriteLine("Журнал пуст");
                Menu();
            }
            else
            {
                Show();
                Console.Write("Введите номер ученика: ");
                int rem = Convert.ToInt32(Console.ReadLine());
                if(rem > name.Count)
                    Console.WriteLine("ученика под номером " + rem + " не существует");
                else
                {
                    name.RemoveAt(rem-1);
                    classNumber.RemoveAt(rem-1);
                    Console.WriteLine("информация удалена");
                }
                
            }
            
        }

        private static void AddInf()
        {
            Console.WriteLine("");
            Console.Write("имя: ");
            string userInputName = Console.ReadLine();
            Console.Write("класс: ");
            string userInputClassNumber = Console.ReadLine();
            name.Add(userInputName);
            classNumber.Add(userInputClassNumber);
            Console.WriteLine("информация добавлена");
        }

        private static void Show()
        {
            Console.WriteLine("");
            if (name.Count == 0)
            {
                Console.WriteLine("Журнал пуст");
                Menu();
            }
            else
            {
                Console.WriteLine("№ | Имя | Класс");
                for (int a = 0; a < name.Count; a++)
                {
                    Console.WriteLine(a + 1 + " | " + name[a] + " | " + classNumber[a]);
                }
            }
        }
        private static void Sort()
        {
            if (name.Count == 0)
            {
                Console.WriteLine("Журнал пуст");
                Menu();
            }
            else
            {
                for (int i = 0; i < classNumber.Count-1 + 1; i++)
                {
                    for (int j = 1; j < classNumber.Count; j++)
                    {
                        if (Convert.ToInt32(classNumber[i]) > Convert.ToInt32(classNumber[j]))
                        {
                            (classNumber[i], classNumber[j]) = (classNumber[j], classNumber[i]);
                            (name[i], name[j]) = (name[j], name[i]);
                        }
                    }
                }
            }
        }
    }
}