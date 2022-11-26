using System;
namespace FactoryMethodExample
{
    //абстрактний клас творця, який має абстрактний метод FactoryMethod, що приймає тип продукта
    public abstract class Creator
    {
        public abstract Product FactoryMethod(int type);
    }

    public class Truthfulness : Creator
    {
        public override Product FactoryMethod(int type)
        {
            switch (type)
            {
                //повертає об'єкт A, якщо type==1
                case 0: return new False();
                //повертає об'єкт B, якщо type==2  
                case 1: return new True();
                default: return new True();
            }
        }
    }

    public abstract class Product { } //абстрактний клас продукт

    //конкретні продукти з різною реалізацією
    public class False : Product { }

    public class True : Product { }

    class MainApp
    {
        static void Main()
        {       //створюємо творця
            Creator creator = new Truthfulness();
            for (int i = 0; i <= 2; i++)
            {
                //створюємо спочатку продукт з типом 1, потім з типом 2
                var product = creator.FactoryMethod(i);
                Console.WriteLine("Where id = {0}, Created {1} ", i, product.GetType());
            }
            Console.ReadKey();
        }
    }
}
