using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10PR
{
    interface IPart
    {
        void Build();
    }

    interface IWorker
    {
        void DoWork(IPart part);
    }

    class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building the basement...");
        }
    }

    class Walls : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building the walls...");
        }
    }

    class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Installing the door...");
        }
    }

    class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Installing the window...");
        }
    }

    class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building the roof...");
        }
    }

  
    class Worker : IWorker
    {
        public void DoWork(IPart part)
        {
            part.Build();
        }
    }
    class TeamLeader : IWorker
    {
        public void DoWork(IPart part)
        {
            Console.WriteLine("Checking the progress of the work...");
        }
    }

   



    class Program
    {
        static void Main()
        {
            House house = new House();
            Team team = new Team();
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new TeamLeader());

            team.BuildHouse(house);


        }
    }

}
