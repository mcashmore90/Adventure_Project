using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character;

namespace Adventure_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Race> races = new Races().races;
            CharacterClasses chrClasses = new CharacterClasses();

            string name = "";
            Race race;
            CharacterClass chrClass = new CharacterClass();

            bool nameSelected = false;
            bool raceSelected = false;
            bool classSelected = false;
            bool chrCreated = false;


            Console.WriteLine("******************************");
            Console.WriteLine("*   Adventure Project Demo   *");
            Console.WriteLine("*                            *");
            Console.WriteLine("******************************\n");


            while (!chrCreated)
            {
                //User name
                while (!nameSelected)
                {
                    Console.WriteLine("Select characters name");
                    name = Console.ReadLine();
                    Console.WriteLine($"\nUse name: {name}?\nY=Confirm  N=Redo");
                    string inputName = Console.ReadLine().ToUpper();

                    switch (inputName)
                    {
                        case "Y":
                            Console.WriteLine("Character name comfirmed\n");
                            nameSelected = !nameSelected;
                            break;
                        case "N":
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }

                //Select Race

                //Select class
                while (!classSelected)
                {
                    Console.WriteLine("Select class");
                    chrClasses.DisplayClasses();

                    int selClass = int.Parse(Console.ReadLine())-1;
                    Console.WriteLine($"\nUse Class: {chrClasses.classes[selClass].Name}?\nY=Confirm  N=Redo");
                    string inputClass = Console.ReadLine().ToUpper();

                    switch (inputClass)
                    {
                        case "Y":
                            Console.WriteLine("Character name comfirmed\n");
                            chrClass = chrClasses.classes[selClass];
                            classSelected = !classSelected;
                            break;
                        case "N":
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }

                Character.Character player = new Character.Character(name, chrClass);


                //Character.Character character = new Character.Character("Max", r[1]);
                Console.WriteLine("-Review Character Info-");
                player.displayInfo();

                //Final confirmation for character creation
                Console.WriteLine("\nY=Confirm  N=Select Name  C=Select Class  R=Select Race\nX=Exit");
                string inputCreate = Console.ReadLine().ToUpper();
                
                switch(inputCreate)
                {
                    case "N":
                        nameSelected = !nameSelected;
                        Console.Clear();
                        break;
                    case "C":
                        classSelected = !classSelected;
                        break;

                    case "Y":
                        chrCreated = !chrCreated;
                        break;
                }

            }

            Console.WriteLine("Character creation complete");
            Console.ReadLine();
        }
    }
}
