using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Uses rudimentary WinForm GUI to accept user input to add a single Ingredient to Player's Cauldron.
     * Created 1/5/25
     */
    public class WinFormAddIngredientHandler : IAddIngredientHandler
    {
        public void HandleAddIngredient(Player player)
        {
            // TODO only show ingredients from player's satchel
            IngredientPhaseGui ingredientForm = new IngredientPhaseGui();
            ingredientForm.ShowDialog();

            if (ingredientForm.IsCatalyst)
            {
                TryAddCatalyst(player, ingredientForm.Catalyst);
            }
            else
            {
                player.AddToCauldron(ingredientForm.Strength);
            }
        }

        private void TryAddCatalyst(Player player, CatalystType type)
        {
            if (!player.AddCatalyst(type))
            {
                HandleAddIngredient(player);
            }
        }
    }
}
