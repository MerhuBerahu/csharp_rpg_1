using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_rpg_1
{
    public class Player
    {
        public string name;
        public Races race;

        public Player()
        {
            this.name = "George";
            this.race = new Races.Human();
            Console.WriteLine("Race HP = " + this.race.hp);
        }

    }
}
