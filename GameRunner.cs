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
            //Form gui = new StartScreenGui();
            //gui.ShowDialog();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreenGui());
        }
    }
}