using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace TheGodsBelow
{
    public partial class TheGodsBelowPlayer : ModPlayer
    {
        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genDust, ref PlayerDeathReason damageSource)
        {
            if (phoenixsBlessing)
            {
                if (Player.statLife < 1)
                    Player.statLife = Player.statLifeMax / 2;
                
                return false;
            }
            
            return true;
        }
    }
}
