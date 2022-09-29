using System;
using System.Collections.Generic;

namespace Classes_basic_task
{
    class Program
    {
        abstract class Worker
        {
            public Worker (string Name, string Position, string WorkDay)
            {
                this.Name = Name;
                this.Position = Position;
                this.WorkDay = WorkDay;
            }
            public string Name, Position, WorkDay;
            protected void Call()
            { }
            protected void WriteCode()
            { }
            protected void Relax()
            { }
            public abstract void FillWorkDay();

        }
        class Developer : Worker
        {
            public Developer (string Name, string Position, string WorkDay) : base(Name, Position, WorkDay)
            {
                Position = "Розробник";
            }
            public override void FillWorkDay()
            {
                WriteCode();
                Call();
                Relax();
                WriteCode();
            }
        }
        class Manager : Worker
        {
            public Manager(string Name, string Position, string WorkDay) : base(Name, Position, WorkDay)
            {
            }
            private Random rand;
            public override void FillWorkDay()
            {
                for (int i = 0; i < rand.Next(10) + 1; i++)
                {
                    Call();
                }
                Relax();
                for (int i = 0; i < rand.Next(5) + 1; i++)
                {
                    Call();
                }
            }
        }
        class Team
        {
            Team(string name)
            {
                this.name = name;
            }
            private string name;
            public void add_teammate(Worker teammate)
            {
                team_list.Push(teammate);
            }
            public void show_info()
            {

            }
            public void show_detailed_info()
            {
                Console.WriteLine(name);
                foreach (Worker teammate in team_list)
                {
                    Console.WriteLine($"<{teammate.Name}> - <{teammate.Position}> - <{teammate.WorkDay}>$");
                }
            }
            private Stack <Worker> team_list = new Stack<Worker>();
        }
        static void Main(string[] args)
        {
  
        }
    }
}
