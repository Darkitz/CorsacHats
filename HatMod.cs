
using BepInEx;
using BepInEx.IL2CPP;
using Reactor;

using HarmonyLib;
using System;
using System.Linq;
using System.Reflection;
using static CorsacHats.MyHats;

namespace CorsacHats
{
    [BepInPlugin(Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    public class HatMod : BasePlugin
    {

        static internal BepInEx.Logging.ManualLogSource Logger;

        public const string Id = "de.darkitz.corsachats";
        public Harmony _harmony { get; } = new Harmony(Id);


        public override void Load()
        {
            Logger = Log;
            _harmony.PatchAll();
        }
    }
}