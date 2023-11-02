using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10PR
{
    class Team
    {
        private List<IWorker> workers;

        public Team()
        {
            workers = new List<IWorker>();
        }

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void BuildHouse(House house)
        {
            Console.WriteLine("Construction of the house begins...");
            foreach (var worker in workers)
            {
                worker.DoWork(house.GetNextPart());
            }
            Console.WriteLine("Construction of the house is complete.");
            Console.ReadKey();
        }
    }
}
