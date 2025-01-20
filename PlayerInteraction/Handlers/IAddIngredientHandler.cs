using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Facilitates adding ingredient to Player's Cauldron.
     * Created 1/3/25
     */
    public interface IAddIngredientHandler
    {
        void HandleAddIngredient(Player player);
    }
}
