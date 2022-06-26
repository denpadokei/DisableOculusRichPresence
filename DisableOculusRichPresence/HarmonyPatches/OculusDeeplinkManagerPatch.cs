using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisableOculusRichPresence.HarmonyPatches
{
    [HarmonyPatch(typeof(OculusDeeplinkManager), nameof(OculusDeeplinkManager.Init))]
    internal class OculusDeeplinkManagerPatch
    {
        public static bool Prefix(bool __runOriginal)
        {
            if (!__runOriginal) {
                return __runOriginal;
            }
            __runOriginal = false;
            return __runOriginal;
        }
    }
}
