using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GUI
{
    internal class GuiEventListener
    {
        private bool AddIngButtonPressed = false;
        public void WaitForAddIngredientButtonPress()
        {
            while (!AddIngButtonPressed) { }
            AddIngButtonPressed = false;
        }

        public void AddIngredientButtonPressed()
        {
            AddIngButtonPressed = true;
        }
    }
}
