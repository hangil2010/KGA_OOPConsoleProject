using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObject
{
    public abstract class GameObject : IInteractable
    {
        public string name;
        public string desc;

        public GameObject(string name, string desc)
        {
            this.name = name;
            this.desc = desc;
        }
        public abstract void Interact(Player player);
    }
}
