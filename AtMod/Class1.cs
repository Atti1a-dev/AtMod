using BepInEx;
using RoR2;

namespace Atti1a
{
    [BepInDependency("com.bepis.r2api")]
    //Change these
    [BepInPlugin("com.Atti1a.AtMod", "Atti1a's Mod", "1.0.0")]
    public class AtMod : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogMessage("Loaded AtMod!");
            On.EntityStates.Huntress.ArrowRain.OnEnter += (orig, self) =>
            {
                // [The code we want to run]
                Chat.AddMessage("You used Huntress's Arrow Rain!");

                // Call the original function (orig)
                // on the object it's normally called on (self)
                orig(self);
            };
        }
    }
}