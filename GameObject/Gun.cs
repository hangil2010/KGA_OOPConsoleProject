using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObject
{
    public class Gun : Item
    {
        private int damage;
        public int Damage { get { return  damage; } set { damage = value; } }
        public Gun(string name, string desc, int damage) : base(name, desc)
        {
            this.damage = damage;
        }

        public override void Use()
        {

        }
    }
}
