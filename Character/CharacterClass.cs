using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    //Holds character chosen class
    public class CharacterClass
    {
        private string _name;

        public CharacterClass() { }

        public CharacterClass(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
    }

    public class CharacterClasses
    {
        public List<CharacterClass> classes = new List<CharacterClass>
        {
            new CharacterClass("Fighter"),
            new CharacterClass("Barbarian"),
            new CharacterClass("Cleric"),
            new CharacterClass("Druid"),
            new CharacterClass("Rouge")
        };

        public void DisplayClasses()
        {
            string display = "";

            for(int i=0; i<classes.Count;i++)
            {
                display += $"{i+1}: {classes[i].Name}\n";
            }

            Console.WriteLine(display);
        }
    }
}
