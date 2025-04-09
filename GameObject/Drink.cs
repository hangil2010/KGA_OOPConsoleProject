using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObject
{
    public class Drink : Item
    {
        public Drink(string name, string desc) : base(name, desc)
        {
        }

        public override void Use()
        {
            Game.player.Heal(30);
        }
    }
}
