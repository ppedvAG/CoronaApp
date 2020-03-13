﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaApp.Data
{
    public class Aufgabe
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime ErledigtBis { get; set; }
        public Boolean Erledigt { get; set; }
        public Boolean Bearbeiten { get; set; }
    }
}
