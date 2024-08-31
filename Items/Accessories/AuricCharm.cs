using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Materials;
using CalamityMod.Rarities;
using CalamityMod.Tiles.Furniture.CraftingStations;
using Terraria;
using Terraria.ModLoader;

namespace TheGodsBelow.Items.Accessories
{
    public class AuricCharm : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Accessories";

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.accessory = true;
            Item.rare = ModContent.RarityType<Violet>();
            Item.value = CalamityGlobalItem.RarityVioletBuyPrice;
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            var modPlayer = Main.LocalPlayer.GetModPlayer<TheGodsBelowPlayer>();
            modPlayer.auricCharm = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<NecklaceofVexation>()
                .AddIngredient<AuricBar>(15)
                .AddIngredient<AscendantSpiritEssence>(5)
                .AddTile<CosmicAnvil>()
                .Register();
        }
    }
}
