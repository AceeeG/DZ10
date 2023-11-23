using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Building
    {
        private static uint id_counter = 1;
        private uint id;
        private double height;
        private int level_count;
        private int entrance_count;
        private int room_count;


        /// <summary>
        /// Заполняет здание
        /// </summary>
        public Building()
        {
            id = id_counter;
            id_counter++;
            height = 45;
            level_count = 15;
            entrance_count = 10;
            room_count = 600;
        }

        /// <summary>
        /// Считает и выводит высоту этажа
        /// </summary>
        /// <param name="level"> этаж </param>
        public void CalculateHeightOfLevel(int level)
        {
            double level_height = height / level_count * level;
            Console.WriteLine($"Высота {level} этажа: {level_height} м");
        }

        /// <summary>
        /// Считает и выводит кол - во комнат в подьезде
        /// </summary>
        public void CalculateRoomsInEnterance()
        {
            double room_in_enterance = room_count / entrance_count;
            Console.WriteLine($"В одном подьезде комнат: {room_in_enterance}");
        }

        /// <summary>
        /// Считает и выводит кол - во комнат на этаже
        /// </summary>
        public void CalculateRoomsInFloor()
        {
            double room_in_floor = (room_count / entrance_count) / level_count;
            Console.WriteLine($"На одном этаже комнат: {room_in_floor}");
        }

        /// <summary>
        /// Возращает количество этажей
        /// </summary>
        /// <returns> Количество этажей</returns>
        public int GetLevelCount()
        {
            return level_count;
        }

        /// <summary>
        /// Выводит информацию о здании
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Номер дома {id}, высота {height} м, этажей {level_count}, подьездов {entrance_count}, комнат {room_count}");
        }
    }
}
