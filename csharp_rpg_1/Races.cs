using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_rpg_1
{
    public class Races
    {
        public string name;
        public string description;
        public int hp;
        public int mp;
        public int strength;
        public int dexterity;
        public int vitality;
        public int agility;
        public int intelligence;
        public int mind;
        public int charisma;

        public class Human:Races
        {
            //human
            public string name = "Human";
            string description = "The most prevalent of the races, also the shortest lived.";
            int hp = 20;
            public int mp = 20;
            public int strength = 5;
            public int dexterity = 5;
            public int vitality = 5;
            public int agility = 5;
            public int intelligence = 5;
            public int mind = 5;
            public int charisma = 5;
        }


        //elf
        public class Elf
        {
            public string name = "Elve's";
            public string description = "The long lived elves, despised by many";
            public int hp = 20;
            public int mp = 20;
            public int strength = 5;
            public int dexterity = 5;
            public int vitality = 5;
            public int agility = 5;
            public int intelligence = 5;
            public int mind = 5;
            public int charisma = 5;
        }

        //dwarf

        //orc

        //goblin
    }
}
