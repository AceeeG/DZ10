using System.Collections.Generic;

namespace Execises
{
    internal class Student
    {
        static private int id_counter = 0;
        public int Id_counter 
        { 
            get
            {
                return id_counter;
            }
        }
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private int group;
        public int Group
        {
            get
            {
                return group;
            }
        }
        private List<bool> visits;
        public List<bool> Visits
        {
            get 
            { 
                return visits;
            }
            set 
            { 
                visits = value; 
            }
        }
        private bool is_skiper;
        public bool Is_skiper
        {
            get 
            { 
                return is_skiper; 
            }
            set 
            { 
                is_skiper = value; 
            }
        }
        private bool want_visit;
        public bool Want_visit
        {
            get
            { 
                return want_visit;
            }
            set
            {
                want_visit = value;
            }
        }
        /// <summary>
        /// Конструктор студента
        /// </summary>
        /// <param name="name"></param>
        /// <param name="group"></param>
        public Student(string name, int group)
        {
            id_counter++;
            id = id_counter;
            this.name = name;
            this.group = group;
            visits = new List<bool>();
            Is_skiper = true;
            want_visit = false;
        }
        /// <summary>
        /// Метод, который определяет бездельник студент или нет
        /// </summary>
        /// <returns></returns>
        public bool CountVisits()
        {
            if (visits.Count > 2 && (visits[visits.Count - 1] == true || visits[visits.Count - 2] == true) || visits[visits.Count - 3] == true)
            {
                is_skiper = false;
                return false;
            }
            if(visits.Count == 2 && (visits[visits.Count - 1] == true || visits[visits.Count - 2] == true))
            {
                is_skiper = false;
                return false;
            }
            if( visits.Count == 1 && (visits[visits.Count - 1] == true))
            {
                is_skiper = false;
                return false;
            }
            else
            {
                is_skiper = true;
                return true;
            }

        }
    }
}
