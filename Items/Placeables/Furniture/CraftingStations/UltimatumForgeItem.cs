using CalamityMod;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Placeables.Furniture.CraftingStations;
using CalamityMod.Rarities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheGodsBelow.Tiles.Furniture;

namespace TheGodsBelow.Items.Placeables.Furniture.CraftingStations
{
    public class UltimatumForgeItem : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Placeables";

        public override void SetDefaults()
        {
            // Using draedon's forge as a temporary sprite
            Item.width = 58;
            Item.height = 32;
            Item.createTile = ModContent.TileType<UltimatumForge>();
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.rare = ModContent.RarityType<Violet>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<DraedonsForge>()
                .AddIngredient<CosmicAnvilItem>()
                .AddIngredient<AuricBar>(5)
                .AddIngredient<AscendantSpiritEssence>(15)
                .AddIngredient<Necroplasm>(10)
                .Register();
        }
    }
}
