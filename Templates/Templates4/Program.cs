using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            Tree tree = new Tree();
            Decoration decoration = new Decoration();
            Garland garland = new Garland();

            // Link decorators
            decoration.SetComponent(tree);
            garland.SetComponent(decoration);

            garland.Operation();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Component
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class Tree : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Tree.Operation()");
        }
    }
    // "Decorator"
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    // "Decoration"
    class Decoration : Decorator
    {
        private string decoration;

        public override void Operation()
        {
            base.Operation();
            decoration = "decoration";
            Console.WriteLine("Decoration.Operation()");
        }
    }

    // "Garland" 
    class Garland : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            GarlandLight();
            Console.WriteLine("Garland.Operation()");
        }
        void GarlandLight()
        {
            Console.WriteLine("Let be light there!");
        }
    }
}