using System;
using System.Collections.Generic;
using System.IO;


namespace Execises
{
    internal class Event
    {
        private string name { get; set; }
        private DateTime date { get; set; }
        private int event_group { get; set; }
        private int event_people { get; set; }

        public List<Student> students { get; set; }
        /// <summary>
        /// Конструктор события
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="event_group"></param>
        /// <param name="event_people"></param>
        public Event(string name, DateTime date, int event_group, int event_people)
        {
            this.name = name;
            this.date = date;
            this.event_group = event_group;
            this.event_people = event_people;
        }
        /// <summary>
        /// Метод, который определяет участников события
        /// </summary>
        /// <param name="groups"></param>
        public void Select(List<List<Student>> groups)
        {
            int group = event_group;
            List<int> random_group = new List<int>();
            List<Student> event_students = new List<Student>();
            if (group != groups.Count)
            {
                while (group > 0)
                {
                    int random = new Random().Next(0, groups.Count - 1);
                    if (!random_group.Contains(random))
                    {
                        random_group.Add(random);
                        group--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < groups.Count; i++)
                    random_group.Add(i);
            }

            for (int i = 0; i < groups.Count; i++)
            {
                int people = event_people;
                if (random_group.Contains(i))
                {

                    for (int j = 0; j < groups[i].Count; j++)
                    {
                        if (groups[i][j].Is_skiper && people > 0)
                        {
                            event_students.Add(groups[i][j]);

                            groups[i][j].Is_skiper = false;
                            people--;
                        }
                    }
                    if (people > 0)
                    {
                        for (int j = 0; j < groups[i].Count; j++)
                        {
                            if (!groups[i][j].Is_skiper && people > 0)
                            {
                                event_students.Add(groups[i][j]);
                                groups[i][j].Is_skiper = false;
                                people--;

                            }
                        }
                    }

                }
            }
            foreach (var student in students) // Часть кода для студентов желающих участвовать
            {
                if (student.Want_visit && event_students.Count < event_people)
                {
                    event_students.Add(student);
                }
            }
            students = event_students;
        }


        /// <summary>
        /// Метод выводящий информацию о мероприятии
        /// </summary>
        public void Print()
        {
            StreamWriter write = new StreamWriter("Events.txt");
            write.WriteLine($"Мероприятие: {name}, {date} числа\nУчаствуют: ");
            for (int i = 0; i < students.Count; i++)
            {
                write.WriteLine($"Участвует {students[i].Name}, группа: {students[i].Id}\n");
            }
            write.Close();
        }
    }
}
