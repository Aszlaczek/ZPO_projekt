using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Projekt_AWzorek_167366
{

    abstract class AbsHabit
    {
        public string name { get; set; }
        public bool isDone { get; set; }

    }
    class Habit : AbsHabit, IDescription
    {
        public string description { get; set; }

        public string ShowDescription()
        {
            return description;
        }

        public Habit(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.isDone = false;
        }

        public void ToggleDone()
        {
            this.isDone = !this.isDone;
        }

    }
}
