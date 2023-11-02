using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10PR
{
    class House
    {
        private Queue<IPart> parts;

        public House()
        {
            parts = new Queue<IPart>();
            parts.Enqueue(new Basement());
            parts.Enqueue(new Walls());
            parts.Enqueue(new Walls());
            parts.Enqueue(new Walls());
            parts.Enqueue(new Walls());
            parts.Enqueue(new Door());
            parts.Enqueue(new Window());
            parts.Enqueue(new Window());
            parts.Enqueue(new Window());
            parts.Enqueue(new Window());
            parts.Enqueue(new Roof());
        }

        public IPart GetNextPart()
        {
            if (parts.Count > 0)
            {
                return parts.Dequeue();
            }
            return null;
        }
    }
}
