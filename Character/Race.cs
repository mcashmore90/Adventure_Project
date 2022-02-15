using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    //Names and stats of various races
    public class Race
    {
        private string _name;
        private List<Buff> _buff;

        public Race() { }
        //Basic constructor for now
        public Race(string name)
        {
            this.Name = name;
        }
        public Race(string name, List<Buff> buff)
        {
            this.Name = name;
            this.Buff = buff;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Buff> Buff
        {
            get { return _buff; }
            set { _buff = value; }
        }

    }

    //List of races
    public class Races
    {
        public List<Race> races = new List<Race>
        {
            new Race("Orc", new List<Buff> {new Buff("Extra Strength", 2)}),
            new Race("Human", new List<Buff> {new Buff("Extra Speed", 2),new Buff("Reduced strength", 1)})
        };
    }
}
