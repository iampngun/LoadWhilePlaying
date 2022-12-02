using PulsarModLoader.Chat.Commands.CommandRouter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadWhilePlaying
{
    internal class LoadCommand : ChatCommand
    {
        public static bool commandEnabled = true;

        public override string[] CommandAliases()
        {
            return new string[]
            {
                "load"
            };
        }

        public override string Description()
        {
            return "Opens Save loading menu";
        }

        public override void Execute(string arguments)
        {
            if(commandEnabled)
            {
                PLUIEscapeMenuPatch.loadCommandGiven = true;
            }
        }
    }
}
