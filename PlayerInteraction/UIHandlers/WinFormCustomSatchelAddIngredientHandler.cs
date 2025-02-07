using CosmageV2.GamePhase;
using CosmageV2.GUI;
using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CosmageV2.PlayerInteraction
{
    public class WinFormCustomSatchelAddIngredientHandler : IAddIngredientHandler
    {
        /// <summary>
        /// Launches Windows Forms GUI to prompt Player to add an Ingredient to their Cauldron, or add none.
        /// </summary>
        public void HandleAddIngredient(Player player)
        {
            IngredientPhaseGuiCustomSatchel gui = new IngredientPhaseGuiCustomSatchel(player.Satchel);
            gui.ShowDialog();

            if (gui.isAddingIngredient)
            {
                if (gui.isCatalyst)
                {
                    Catalyst catalyst = gui.selectedIngredient as Catalyst;
                    TryAddCatalyst(player, catalyst);
                }
                else
                {
                    Essence essence = gui.selectedIngredient as Essence;
                    if (essence is null)
                    {
                        HandleAddIngredient(player);
                        return;
                    }

                    player.AddEssenceAndRemoveFromSatchel(essence);
                    GamePhaseManager.Instance.LogEvent($"{player.Name} added {essence.Name}");
                }
            }
        }

        /// <summary>
        /// Tries to add Catalyst to Player's Cauldron. If Cauldron already contains a Catalyst, relaunches GUI.
        /// </summary>
        public void TryAddCatalyst(Player player, Catalyst catalyst)
        {
            if (!player.AddCatalystAndRemoveFromSatchel(catalyst))
            {
                HandleAddIngredient(player);
            }
            else GamePhaseManager.Instance.LogEvent($"{player.Name} added {catalyst.Name}");
        }
    }
}
