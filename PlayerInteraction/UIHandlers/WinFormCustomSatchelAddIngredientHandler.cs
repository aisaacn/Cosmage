﻿using CosmageV2.GamePhase;
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
