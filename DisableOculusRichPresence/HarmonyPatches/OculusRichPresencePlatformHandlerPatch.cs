using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisableOculusRichPresence.HarmonyPatches
{
    [HarmonyPatch(typeof(OculusRichPresencePlatformHandler), nameof(OculusRichPresencePlatformHandler.SetPresence))]
    internal class OculusRichPresencePlatformHandlerPatch
    {
        public static bool Prefix(ref IRichPresenceData richPresenceData, bool __runOriginal)
        {
            Plugin.Log.Debug($"api_name:{richPresenceData.apiName}, localizedDescription:{richPresenceData.localizedDescription}");
            if (!__runOriginal) {
                return __runOriginal;
            }
            __runOriginal = false;
            return __runOriginal;
        }
    }
}
