using BepInEx;
using BepInEx.Logging;
using RoR2;
using System.Reflection;
using UnityEngine;

namespace AtMod
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin(ModGuid, ModName, ModVer)]
    public class AtModPlugin : BaseUnityPlugin
    {
        private const string ModVer = "1.0.0";
        private const string ModName = "Atti1a's Mod";
        internal const string ModGuid = "com.Atti1a.AtMod";
        public static AtModPlugin Instance;
        internal static ManualLogSource atmodLogSource;
        internal static AssetBundle atmodAssetBundle;
        public void Awake()
        {
            if (Instance == null) Instance = this;
            atmodLogSource = Instance.Logger;
            atmodAssetBundle = AssetBundle.LoadFromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AtMod.AtModResources.atmod"));

            Logger.LogMessage("Loaded AtMod!");
        }
    }
}