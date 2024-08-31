using CalamityMod.Buffs.DamageOverTime;
using CalamityMod.Items.Armor.Auric;
using System.Security.Cryptography.X509Certificates;
using Terraria;
using Terraria.ModLoader;

namespace TheGodsBelow
{
    public partial class TheGodsBelowPlayer : ModPlayer
    {
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (auricCharm)
            {
                if (Player.body == AuricTeslaBodyArmor && Player.body == AuricTeslaCuisses)
                {
                    if (Player.head == AuricTeslaHoodedFacemask || Player.head == AuricTeslaPlumedHelm || Player.head == AuricTeslaRoyalHelm ||
                        Player.head == AuricTeslaSpaceHelmet || Player.head == AuricTeslaWireHemmedVisage)
                        target.AddBuff(ModContent.BuffType<Dragonfire>(), 120);
                }
            }
        }
    }
}
