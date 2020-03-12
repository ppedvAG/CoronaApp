using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaApp.Data
{
    public class ToDoVM
    {
        public Aufgabe AktuellAufgabe { get; set; }
        public List<Aufgabe> Aufgaben { get; set; } = new List<Aufgabe>();

        public void Add(Aufgabe a)
        {
            Aufgaben.Add(a);

        }

    }
}
