using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2
{
    internal class Player
    {
        public Element Element { get; }
        public string Name { get; }
        public int Health { get; private set; }

        public Player(Element element, string name) 
        {
            Element = element;
            Name = name;
            Health = 20; //TODO: abstract health for different rulesets
        }
    }
}
