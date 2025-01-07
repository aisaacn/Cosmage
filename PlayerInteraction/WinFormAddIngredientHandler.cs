using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    internal class WinFormAddIngredientHandler : IAddIngredientHandler
    {
        public void HandleAddIngredient(Player player)
        {
            // TODO only show ingredients from player's satchel
            IngredientPhaseGui ingredientForm = new IngredientPhaseGui();
            ingredientForm.ShowDialog();

            if (ingredientForm.isCatalyst)
            {
                TryAddCatalyst(player, ingredientForm.catalyst);
            }
            else
            {
                player.AddToCauldron(ingredientForm.strength);
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
