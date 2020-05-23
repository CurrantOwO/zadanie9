using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentlib
{
    public class Student
    {
        private int Id;
        private string FIO;
        private int Group;
        private string Data;
        ArrayList inf = new ArrayList();
        public int id
        {
            get { return Id; }
            set { if (value >= 0) Id = value; }
        }
        public int grp
        {
            get { return Group; }
            set { if (value >= 0) Group = value; inf.Add(Group); }
        }
        public string fio
        {
            get { return FIO; }
            set { if (value != "" || value != " ") FIO = value; inf.Add(FIO); }
        }
        public string dat
        {
            get { return Data; }
            set { if (value != "" || value != " ") Data = value; inf.Add(Data); }
        }
        public void Info()//список всех студентов
        {
            int li = 1;
            for (int i = 0; i < inf.Count; i++)
            {
                if (i == 0 || i % 3 == 0) { Console.WriteLine("\n\tСтудент №" + li); li++; Console.WriteLine("\n" + inf[i]); }
                else if(i == 1 || i % 3 == 1) { Console.WriteLine("Дата рождения: " + inf[i]); }
                else { Console.WriteLine("Группа №: " + inf[i]); }
            }
        }
        public void add()//добавляем данные
        {
            string n, n1, n2, n3, d, d1, d2, d3;
            do { Console.Write("Введите фамилию студента: ");
                n1 = Convert.ToString(Console.ReadLine()); } while (n1.Length < 3);
            do { Console.Write("Введите имя студента: ");
                n2 = Convert.ToString(Console.ReadLine());
            } while (n2.Length < 4);
            do { Console.Write("Введите отчество студента: ");
                n3 = Convert.ToString(Console.ReadLine());
            } while (n3.Length < 4);
            Console.Write("Введите НОМЕР группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            do { 
                Console.Write("Введите день рождения(01, 02 и т.д.): ");
                d1 = Convert.ToString(Console.ReadLine());
            } while (d1.Length != 2);
            do {
                Console.Write("Введите месяц рождения(01, 02 и т.д.): ");
                d2 = Convert.ToString(Console.ReadLine());
            } while (d2.Length != 2);
            do {
                Console.Write("Введите год рождения(1999, 2000 и т.д.): ");
                d3 = Convert.ToString(Console.ReadLine());
            } while (d3.Length != 4);
            n = n1 + " " + n2 + " " + n3;
            d = d1 + "." + d2 + "." + d3;
            fio = n;
            grp = g;
            dat = d;
            Console.WriteLine("Студент успешно добавлен.\n");
        }
        public void redakt()//изменяем
        {
            string n, n1, n2, n3, d, d1, d2, d3;
            do { Console.Write("Введите фамилию студента: ");
                n1 = Convert.ToString(Console.ReadLine());
            } while (n1.Length < 3);
            do { Console.Write("Введите имя студента: ");
                n2 = Convert.ToString(Console.ReadLine());
            } while (n2.Length < 4);
            do {  Console.Write("Введите отчество студента: ");
                n3 = Convert.ToString(Console.ReadLine());
            } while (n3.Length < 4);
            int nu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО студента: ");
            n = Convert.ToString(Console.ReadLine());
            Console.Write("Введите НОМЕР группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            do {
                Console.Write("Введите день рождения(01, 02 и т.д.): ");
                d1 = Convert.ToString(Console.ReadLine());
            } while (d1.Length != 2);
            do {
                Console.Write("Введите месяц рождения(01, 02 и т.д.): ");
                d2 = Convert.ToString(Console.ReadLine());
            } while (d2.Length != 2);
            do {
                Console.Write("Введите год рождения(1999, 2000 и т.д.): ");
                d3 = Convert.ToString(Console.ReadLine());
            } while (d3.Length != 4);
            d = d1 + "." + d2 + "." + d3;
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            inf[nu - 1] = n;
            inf[nu] = d;
            inf[nu + 1] = g;
            Console.WriteLine("Студент успешно изменен.\n");
        }
        public void Dell()//удаляем
        {
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            inf.RemoveRange(nu - 1, 3);
            Console.WriteLine("Студент успешно удален.\n");
        }
        public void Sid()//поиск по id
        {
            Console.Write("Выберите номер студента: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int nu = num, du = nu, u = 0;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            du = nu;
            u = inf.Count / 3;
            if (num > u) { Console.WriteLine("\n\n!!!!!!!!!!  В базе данных нет студента с таким id  !!!!!!!!!!\n"); }
            else { Console.WriteLine("\t" + inf[nu - 1] + "\n\tДата рождения: " + inf[nu] + "\n\tГруппа №: " + inf[nu + 1]); }
        }
        public void Old()//считаем возраст у студентов под вводим id
        {
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            string s = inf[nu] + "";
            Console.WriteLine(s);
            s = s.Substring(s.Length - 4);
            int z = Convert.ToInt32(s);
            z = 2020 - z;
            Console.WriteLine("В этом году студенту " + z);
        }
        public void Inic()//Выводим инициалы
        {
            for (int i = 0; i < inf.Count; i += 3)
            {
                string s = inf[i] + "";
                string[] inc = s.Split(' ');
                string z = inc[1], l = inc[2];
                s = inc[0] + " " + z[0] + ". " + l[0] + ". ";
                Console.WriteLine("\n\t" + s);
            }
        }
        public void sor(char la)//сортировка по возрасту "s" "a" 
        {
            if (la == 's') { Console.WriteLine("Суденты старше 18 лет:"); }
            else if (la == 'a') { Console.WriteLine("Суденты младше 18 лет:"); }
            for (int i = 1; i < inf.Count; i += 3)
            {
                string s = inf[i] + "";
                s = s.Substring(s.Length - 4);
                int z = Convert.ToInt32(s);
                z = 2020 - z;
                int f = i / 3 + 1;
                if (z > 18 && la == 's')
                {
                    Console.WriteLine("\nСтудент №" + f);
                    Console.WriteLine("\t" + inf[i - 1] + "\n\tДата рождения: " + inf[i] + "\n\tГруппа №: " + inf[i + 1]);
                }
                else if (z < 18 && la == 'a')
                {
                    Console.WriteLine("\nСтудент №" + f);
                    Console.WriteLine("\t" + inf[i - 1] + "\n\tДата рождения: " + inf[i] + "\n\tГруппа №: " + inf[i + 1]);
                }
            }
        }
        public void ser()//Поиск по фамилии
        {
            string sa = Convert.ToString(Console.ReadLine());
            int za = 0;
            for (int i = 0; i < inf.Count; i += 3)
            {
                string s = inf[i] + "";
                int a = 0;
                for (int la = 0; la < sa.Length; la++)
                {
                    if (sa[la] == s[la]) { a++; }
                }
                if (a == sa.Length) { Console.WriteLine(s); za++; }
            }
            if(za == 0) { Console.WriteLine("\nСовпадения не найдены\n"); }
        }
    }

}
