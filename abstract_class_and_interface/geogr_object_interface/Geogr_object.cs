using System;
using System.Collections.Generic;
using System.Text;

namespace geogr_object_interface
{
    interface IGeogr_object
    {
        public (double, double) get_coords();
        public string get_title();
        public string get_description();
        virtual public void display_info()
        {

        }
    }
    class River : IGeogr_object
    {
        protected double coord_x, coord_y;
        protected string title, description;
        private short flow_speed, length;
        public (double, double) get_coords()
        {
            return (coord_x, coord_y);
        }
        public string get_title()
        {
            return title;
        }
        public string get_description()
        {
            return description;
        }
        virtual public void display_info()
        {
            Console.WriteLine("Тип географічного об'єкту: Річка");
            Console.WriteLine($"Назва географічного об'єкту: {title}$");
            Console.WriteLine($"Координата x: {coord_x}$");
            Console.WriteLine($"Координата y: {coord_y}$");
            Console.WriteLine($"Середня швидкість потоку (см/с): {flow_speed}$");
            Console.WriteLine($"Загальна довжина (км): {length}$");
        }
    }
    class Mountain : IGeogr_object
    {
        protected double coord_x, coord_y;
        protected string title, description;
        private short summit;
        public (double, double) get_coords()
        {
            return (coord_x, coord_y);
        }
        public string get_title()
        {
            return title;
        }
        public string get_description()
        {
            return description;
        }
        virtual public void display_info()
        {
            Console.WriteLine("Тип географічного об'єкту: Гора");
            Console.WriteLine($"Назва географічного об'єкту: {title}$");
            Console.WriteLine($"Координата x: {coord_x}$");
            Console.WriteLine($"Координата y: {coord_y}$");
            Console.WriteLine($"Висота вершини над рівнем моря (м): {summit}$");
        }
    }
}
