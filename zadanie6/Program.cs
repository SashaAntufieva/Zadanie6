using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zadanie6
{
    class Student
    {
        public int ID;
        public string FIO;
        public string Group;
        public string Data;

        ArrayList student = new ArrayList();
        ArrayList students = new ArrayList();
        ArrayList fio = new ArrayList();
        ArrayList id = new ArrayList();
        ArrayList data = new ArrayList();
        public void dobavit()
        {
            Console.WriteLine("Введите данные студента");
            Random rnd = new Random();
            ID = rnd.Next(20);
            Console.WriteLine("Введите ФИО");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите Группу");
            Group = Console.ReadLine();
            Console.WriteLine("Введите Дату(dd.mm.yyyy)");
            Data = Console.ReadLine();
            student = new ArrayList();
            student.Add(ID);
            student.Add(FIO);
            student.Add(Group);
            student.Add(Data);
            id.Add(ID);
            fio.Add(FIO);
            data.Add(Data);
            string lo = "ID студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата: " + student[3];
            students.Add(lo);
        }
        public void izmenit()
        {
            int po = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + po + " ), которого надо изменить");
            int lo = Convert.ToInt32(Console.ReadLine());
            fio.RemoveAt(lo);
            Console.WriteLine("Выберите, что нужно изменить: \n1 - ФИО\n2 - Группу\n3 - Дату рождения");
            int meow = Convert.ToInt32(Console.ReadLine());
            if (meow == 1)
            {
                Console.WriteLine("Введите ФИО");
                string fiO = Console.ReadLine();
                student[1] = fiO;
                fio.Add(fiO);
            }
            if (meow == 2)
            {
                Console.WriteLine("Введите Группу");
                string group = Console.ReadLine();
                student[2] = group;
            }
            if (meow == 3)
            {
                Console.WriteLine("Введите Дату(dd.mm.yyyy)");
                string data = Console.ReadLine();
                student[3] = data;
            }
            string mr = "ID студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата: " + student[3];
            students[lo] = mr;
        }

        public void delite()
        {
            int kri = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + kri + " ), которого надо удалить");
            int lo = Convert.ToInt32(Console.ReadLine());
            students.RemoveAt(lo);
        }
        public void inf()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + "\n");
            }
        }

        public void infFIO()
        {
            Console.WriteLine("Список студентов:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(fio[i]);
            }
        }

        public void infID()
        {
            Console.WriteLine("Id студентов:");
            int minwon = 0;
            for (int kiho = 0; kiho < id.Count; kiho++)
            {
                Console.WriteLine(id[kiho]);
                minwon++;
            }
            int[] hg = new int[minwon];
            id.CopyTo(hg);
            Console.WriteLine("Введите ID студента");
            int xiusoo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Информация о студенте:");
            for (int voda  = 0; voda < id.Count; voda++)
            {
                if (xiusoo == hg[voda])
                {
                    Console.WriteLine(students[voda]);
                }
            }
        }

        public void Vdata()
        {
            Console.WriteLine("Id студентов:");
            int minwon = 0;
            int[] pelmen = new int[4];
            int okroska = 0;
            int ff;
            for (int kiho = 0; kiho < id.Count; kiho++)
            {
                Console.WriteLine(id[kiho]);
                minwon++;
            }
            int[] hg = new int[minwon];
            id.CopyTo(hg);
            Console.WriteLine("Введите ID студента");
            int xiusoo = Convert.ToInt32(Console.ReadLine());
            for (int voda = 0; voda < id.Count; voda++)
            {
                if (xiusoo == hg[voda])
                {
                    string lo = data[voda].ToString();
                    char[] ss = lo.ToCharArray();
                    pelmen[0] = ss[6] - '0';
                    pelmen[1] = ss[7] - '0';
                    pelmen[2] = ss[8] - '0';
                    pelmen[3] = ss[9] - '0';
                    for (int kiho = 0; kiho < 4; kiho++)
                    {
                        okroska = okroska * 10 + pelmen[kiho];
                    }
                }
            }
            ff = 2020 - okroska;
            Console.WriteLine("Возраст студента: " + ff);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student lo = new Student();
            lo.dobavit(); Console.WriteLine();
            lo.dobavit(); Console.WriteLine();
            lo.dobavit(); Console.WriteLine();
            lo.infFIO(); Console.WriteLine();
            lo.infID(); Console.WriteLine();
            lo.Vdata();
        }
    }
}

