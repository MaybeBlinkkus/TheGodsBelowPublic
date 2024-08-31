using CalamityMod.Items;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheGodsBelow.Systems;

namespace TheGodsBelow.Items.Weapons.Melee
{
    public class VorpalSword : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Weapons.Melee";
        public int random;
        private readonly List<int> OneToFifteen = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        public override void SetDefaults()
        {
            Item.damage = 60;
            Item.DamageType = DamageClass.Melee;
            Item.width = 50;
            Item.height = 50;
            Item.useAnimation = 25;
            Item.useTime = 25;
            Item.rare = ItemRarityID.Pink;
            Item.value = CalamityGlobalItem.RarityPinkBuyPrice;
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            foreach (int boss in TheGodsBelowLists.bossesList)
            {
                if (target.type == boss)
                {
                    return;
                }
                else
                {
                    random = Main.rand.Next(1, 100);
                    foreach (int number in OneToFifteen)
                    {
                        if (random == number)
                            VorpalStrikeSystem.VorpalStrikeNPC(target);
                    }
                }
            }
        }

        public override void OnHitPvp(Player player, Player target, Player.HurtInfo hurtInfo)
        {
            if (target.statDefense > Item.damage)
            {
                random = Main.rand.Next(1, 100);
                foreach (int number in OneToFifteen)
                {
                    if (random == number)
                        VorpalStrikeSystem.VorpalStrikePvp(target);
                }
            }
        }
    }
}
