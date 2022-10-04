using System;

namespace abstract_class_and_interface
{
    class Program
    {
        abstract class Geogr_object
        {
            protected double coord_x, coord_y;
            protected string title, description;
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
                Console.WriteLine($"Назва географічного об'єкту: {title}$");
                Console.WriteLine($"Координата x: {coord_x}$");
                Console.WriteLine($"Координата y: {coord_y}$");
            }
        }
        class River : Geogr_object
        {
            private short flow_speed, length; 
            
            public short get_flow_speed() // Середня швидкість течії у сантиметрах на секунду
            {
                return flow_speed;
            }
            public short get_length() // Загальна довжина річки у кілометрах
            {
                return length;
            }
            public override void display_info()
            {
                Console.WriteLine("Тип географічного об'єкту: Річка");
                base.display_info();
                Console.WriteLine($"Середня швидкість потоку (см/с): {flow_speed}$");
                Console.WriteLine($"Загальна довжина (км): {length}$");
            }
        }
        class Mountain : Geogr_object
        {
            private short summit; // Рівень вершини над рівнем моря у метрах
            public short get_summit()
            {
                return summit;
            }
            public override void display_info()
            {
                Console.WriteLine("Тип географічного об'єкту: Гора");
                base.display_info();
                Console.WriteLine($"Висота вершини над рівнем моря (м): {summit}$");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
