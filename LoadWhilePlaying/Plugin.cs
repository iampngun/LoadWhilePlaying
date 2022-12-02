using PulsarModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PulsarModLoader.PulsarMod;

namespace LoadWhilePlaying
{
    public class Plugin : PulsarMod
    {
        public override string HarmonyIdentifier()
        {
            return "pngun.LoadWhilePlaying";
        }
        public override string Author => "pngun";
        public override string ShortDescription => "Allows Host to load another save without losing/disconnecting.";
        public override string LongDescription => "To use press 'Enter' to open chat and type /load, " +
            "then press 'Enter' again to execute. This will open a menu where you can choose which save to load.";
        public override string Name => "LoadWhilePlaying";
        public override string Version => "0.0.2";
    }
}
