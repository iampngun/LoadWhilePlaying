using PulsarModLoader.CustomGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LoadWhilePlaying
{
    internal class GUI : ModSettingsMenu
    {
        public override void Draw()
        {
            string text = "Load command is now " + (LoadCommand.commandEnabled ? "Enabled" : "Disabled");
            bool flag = GUILayout.Button(text, Array.Empty<GUILayoutOption>());
            if (flag)
            {
                LoadCommand.commandEnabled = !LoadCommand.commandEnabled;
            }
        }

        public override string Name()
        {
            return "LoadWhilePlaying";
        }
    }
}
