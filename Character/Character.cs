using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Character
{
    //Basic information of character
    public class Character
    {
        private string _name;
        private int _currentHealth = 10;
        private int _maxHealth = 10;

        public Race Race;
        public CharacterClass ChrClass;
        public Stats Stats;
        public Actions Action;

        //Default character constructor
        public Character(string name, Race race, CharacterClass cc) 
        {
            this._name = name;
            this.Race = race;
            this.ChrClass = cc ;
        }

        //Character constructors for testing
        public Character(string name)
        {
            this._name = name;
        }

        public Character(string name, CharacterClass cc)
        {
            this._name = name;
            this.ChrClass = cc;
        }

        public Character(string name, Race race)
        {
            this._name = name;
            this.Race = race;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int CurrentHealth
        {
            get { return this._currentHealth; }
            set { this._currentHealth = value; }
        }

        public int MaxHealth
        {
            get { return this._maxHealth; }
            set { this._maxHealth = value; }
        }

        public void displayInfo()
        {
            //string display = $"Name: {Name}\nRace: {Race.Name}\nHealth: {CurrentHealth}/{MaxHealth}\n\nTraits and Buffs\n";
            string display = $"Name: {Name}\nClass: {ChrClass.Name}";
            
            //Displays buffs/debuffs when implamented
            //foreach(Buff buff in Race.Buff)
            //{
            //    display += $"{buff.Type} : {buff.Value}\n";
            //}

            Console.WriteLine(display);
        }
       
    }
}
