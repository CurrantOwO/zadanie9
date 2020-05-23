using System;
using studentlib;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();

            a.fio = "Зябликов Василий Петячкин";
            a.dat = "12.10.2003";
            a.grp = 12;
            a.fio = "Зяблов Васий Потчкин";
            a.dat = "12.10.2000";
            a.grp = 12;
            a.fio = "Баулов Валентин Валович";
            a.dat = "04.11.1997";
            a.grp = 8;
            a.fio = "Енулов Антон Вилович";
            a.dat = "02.12.2005";
            a.grp = 6;
            a.fio = "Рубцов Сергей Виторович";
            a.dat = "03.12.1919";
            a.grp = 808;
            int n = 0;
            while (n != 6)
            {
                Console.WriteLine("\n___________________________________________\n\n\t\tМеню\n___________________________________________");
                Console.WriteLine("\nДля выполнения действий нажмите следующую цифру:\n");
                Console.WriteLine("\t1.Показать Информацию о студентах");
                Console.WriteLine("\t2.Добавить студента\n\t3.Удалить сдутента\n\t4.Изменить студента\n\t5.Поиск студентов\n\t6.Выход\n");

                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0 || n >= 7) { Console.WriteLine("Нажмите нужную цифру"); }
                switch (n)
                {
                    case 1:
                        {
                            int no;
                            do
                            {
                                Console.WriteLine("\n___________________________________________\n\n\t\tПодменю\n___________________________________________");
                                Console.WriteLine("\nЧто именно вы хотите?\n\n\t1.Вся информация о студентах\n\t2.Список студентов с инициалами\n\t" +
                                    "3.Список студентов старше 18\n\t4.Список студентов младше 18\n\t5.Переход в главное меню\n");
                                do
                                {
                                    no = Convert.ToInt32(Console.ReadLine());
                                    if (no < 1 || no > 5) { Console.WriteLine("Нажмите нужную цифру"); }
                                } while (no < 1 || no > 5);
                                switch (no)
                                {
                                    case 1: { a.Info(); break; }
                                    case 2: { a.Inic(); break; }
                                    case 3: { a.sor('s'); break; }
                                    case 4: { a.sor('a'); break; }
                                }
                            } while (no != 5);
                            break;
                        }
                    case 2: { a.add(); break; }
                    case 3: { a.Dell(); break; }
                    case 4: { a.redakt(); break; }
                    case 5:
                        {
                            int no;
                            do
                            {
                                Console.WriteLine("\n___________________________________________\n\n\t\tПодменю\n___________________________________________");
                                Console.WriteLine("\nЧто именно вы хотите?\n\n\t1.Найти студента по id\n\t2.Найти студента по фамилии\n\t3.Переход в главное меню\n");
                                do
                                {
                                    no = Convert.ToInt32(Console.ReadLine());
                                    if (no < 1 || no > 3) { Console.WriteLine("Нажмите нужную цифру"); }
                                } while (no < 1 || no > 3);
                                switch (no)
                                {
                                    case 1: { a.Sid(); break; }
                                    case 2: { a.ser(); break; }
                                }
                            } while (no != 3);
                            break;
                        }
                }
            }
        }
    }
}
