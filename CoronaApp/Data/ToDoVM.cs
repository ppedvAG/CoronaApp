using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaApp.Data
{
    public class ToDoVM
    {
        public Aufgabe AktuellAufgabe { get; set; } = new Aufgabe();
        public List<Aufgabe> Aufgaben { get; set; } = new List<Aufgabe>();

        public void Addiere(Aufgabe a)
        {
           // Aufgaben.Add(a); böse

            Aufgaben.Add(new Aufgabe
            {
                Text = a.Text,
                ID = Aufgaben.Count
            });


        }

    }
}
