using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheGodsBelow.Systems
{
    public class VorpalStrikeSystem : ModSystem
    {
        public static void VorpalStrikeNPC(NPC target)
        {
            target.life -= int.MaxValue;
            CombatText.NewText(target.Hitbox, Color.OrangeRed, "Vorpal Strike!", dramatic: true);
        }

        public static void VorpalStrikePvp(Player target)
        {
            target.statLife -= int.MaxValue;
            CombatText.NewText(target.Hitbox, Color.OrangeRed, "Vorpal Strike!", dramatic: true);
        }
    }
}
