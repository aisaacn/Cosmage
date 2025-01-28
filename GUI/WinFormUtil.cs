using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2.GUI
{
    public static class WinFormUtil
    {
        readonly static int buttonWidth = 140;
        readonly static int buttonHeight = 40;
        readonly static int padding = 1;

        public static void PopulateControlWithButtonsFromList(Control control, List<Item> items, EventHandler clickHandler)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Button button = new Button()
                {
                    Text = $"{items[i].Name} ({items[i].SatchelWeight})",
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(padding),
                    Tag = i
                };
                button.Click += clickHandler;
                button.MouseHover += (s, e) => (new ToolTip()).SetToolTip((Button)s, items[(int)((Button)s).Tag].Tooltip);
                control.Controls.Add(button);
            }
        }
    }
}
