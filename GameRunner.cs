using CosmageV2.GamePhase;
using CosmageV2.GUI;
using CosmageV2.PlayerInteraction;
using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2
{
    internal class GameRunner
    {
        static void Main()
        {
            // TODO move to PlayerCreator class (should be called from StartScreenGui eventually)
            Player player1 = new Player(Element.Natural, "Player1-N");
            Player player2 = new Player(Element.Mechanical, "Player2-M");

            // TODO simplify Satchel creation. probably shouldn't have all new constructors.
            List<Item> sampleNaturalSatchel = new List<Item>()
            {
                new AttackCrystal(), new WardCrystal(), new ConstructCrystal(),
                new BasicNaturalEssence(), new AdvancedNaturalEssence(),
                new BasicMechanicalEssence(), new AdvancedMechanicalEssence(), new AdvancedMechanicalEssence(),
                new BasicUnnaturalEssence(), new AdvancedUnnaturalEssence(), new AdvancedUnnaturalEssence()
            };

            List<Item> sampleMechanicalSatchel = new List<Item>()
            {
                new AttackCrystal(), new WardCrystal(), new ConstructCrystal(),
                new BasicNaturalEssence(), new AdvancedNaturalEssence(), new AdvancedNaturalEssence(),
                new BasicMechanicalEssence(), new AdvancedMechanicalEssence(),
                new BasicUnnaturalEssence(), new AdvancedUnnaturalEssence(), new AdvancedUnnaturalEssence()
            };

            player1.SetSatchel(new Satchel(sampleNaturalSatchel));
            player2.SetSatchel(new Satchel(sampleMechanicalSatchel));
            GamePhaseManager.Instance.SetPlayers(player1, player2);

            Form gui = new StartScreenGui();
            gui.ShowDialog();
        }
    }
}