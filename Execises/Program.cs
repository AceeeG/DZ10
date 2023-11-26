using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Execises
{
    internal class Program
    {
        /// <summary>
        /// Метод выполняющий первое упражнение
        /// </summary>
        static void DoExercise1()
        {
            Console.WriteLine("Задание 1 - студенты и мероприятия\n");
            List<string> file_lines = File.ReadAllLines("Students.txt").ToList();
            List<Student> students = new List<Student>();
            foreach (var file_line in file_lines)
            {
                var split_line = file_line.Split(new[] {","}, StringSplitOptions.None);
                string name = split_line[0];
                int group = Convert.ToInt32(split_line[1]);
                students.Add(new Student(name, group));
            }
            List<Student> group321 = new List<Student>();
            List<Student> group322 = new List<Student>();

            foreach (Student student in students)
            {
                switch(student.Group)
                {
                    case 321:
                        group321.Add(student);
                        break;
                    case 322:
                        group322.Add(student);
                        break;
                    default:
                        Console.WriteLine("Какой-то фрик\n");
                        break;
                }
            }

            List<List<Student>> PM = new List<List<Student>>() {group321, group322};
            Event event1 = new Event("Театральная постановка", new DateTime(2023, 12, 10), 321, 1);
            event1.Select(PM);
            event1.Print();
            Event event2 = new Event("Концерт", new DateTime(2023, 12, 10), 322, 2);
            event2.Select(PM);
            event2.Print();
            Event event3 = new Event("Игры", new DateTime(2023, 12, 10), 321, 1);
            event3.Select(PM);
            event3.Print();
            Event event4 = new Event("Акробаты", new DateTime(2023, 12, 10), 322, 1);
            event4.Select(PM);
            event4.Print();
            Event event5 = new Event("Студбатл", new DateTime(2023, 12, 10), 322, 2);
            event5.Select(PM);
            event5.Print();

        }
        /// <summary>
        /// Метод, выполняющий второе упражнение
        /// </summary>
        static void DoExercise2()
        {
            Console.WriteLine("Упражнение 2\n");
            int count = 0;
            List<Occasion> occasions = new List<Occasion>() {new Occasion("Выход альбома", Hobbies.Музыка), new Occasion("Матч NBA", Hobbies.Спорт), new Occasion("Бесплатная еда", Hobbies.Бомжевать) };
            Sportsman sportsman = new Sportsman("Псих");
            sportsman.sport_event += DoSport;
            Musician musician = new Musician("Альфред");
            musician.music_event += DoMusic;
            Homeless homeless = new Homeless("Дикарь");
            homeless.home_event += FindHome;
            List<Person> persons = new List<Person>() {sportsman, musician, homeless};
            foreach(Occasion occasion in occasions)
            {
                occasion.Print();
            }
            foreach(Person person in persons)
            {
                if(person.Favorite_hobbie == occasions[0].Hobbie)
                {
                    person.MakeEvent();
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Никому не интересно это событие\n");
            }
        }


        static void Main(string[] args)
        {
            //DoExercise1();
            DoExercise2();
            Console.ReadKey();
        }
        static void DoSport(object sender, EventArgs e) 
        {
            Console.WriteLine($"Пошел заниматься спортом\n");
        }
        private static void DoMusic(object sender, EventArgs e)
        {
            Console.WriteLine($"Пошел заниматься музыкой\n");
        }
        private static void FindHome(object sender, EventArgs e)
        {
            Console.WriteLine($"Пошел бомжевать\n");
        }
    }
}
