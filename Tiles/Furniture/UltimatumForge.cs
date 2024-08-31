using CalamityMod.Tiles.Furniture.CraftingStations;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace TheGodsBelow.Tiles.Furniture
{
    public class UltimatumForge : ModTile
    {
        public override void SetStaticDefaults()
        {
            // Using draedon's forge as a temporary sprite
            Main.tileTable[Type] = false;
            Main.tileSolidTop[Type] = false;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style5x4); // Uses 5x4 style, but reduces height to 3.
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 18 };
            TileObjectData.newTile.Origin = new Point16(2, 1);
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(230, 157, 41), Language.GetText("Mods.TheGodsBelow.Items.Placeables.Furniture.UltimatumForgeItem.DisplayName"));

            AdjTiles = new int[] {
                // Vanilla
                TileID.WorkBenches,
                TileID.Furnaces,
                TileID.Hellforge,
                TileID.Anvils,
                TileID.Bottles,
                TileID.AlchemyTable,
                TileID.Sinks,
                TileID.Sawmill,
                TileID.Loom,
                TileID.Chairs,
                TileID.CookingPots,
                TileID.TinkerersWorkbench,
                TileID.ImbuingStation,
                TileID.DyeVat,
                TileID.HeavyWorkBench,
                TileID.DemonAltar,
                TileID.MythrilAnvil,
                TileID.AdamantiteForge,
                TileID.Bookcases,
                TileID.CrystalBall,
                TileID.Autohammer,
                TileID.LunarCraftingStation,
                TileID.Kegs,
                TileID.TeaKettle,
                TileID.Blendomatic,
                TileID.MeatGrinder,
                TileID.BoneWelder,
                TileID.GlassKiln,
                TileID.HoneyDispenser,
                TileID.IceMachine,
                TileID.LivingLoom,
                TileID.SkyMill,
                TileID.Solidifier,
                TileID.LesionStation,
                TileID.FleshCloningVat,
                TileID.SteampunkBoiler,
                TileID.LihzahrdFurnace,
                // Modded/Calamity
                ModContent.TileType<WulfrumLabstation>(),
                ModContent.TileType<EutrophicShelf>(),
                ModContent.TileType<StaticRefiner>(),
                ModContent.TileType<AncientAltar>(),
                ModContent.TileType<AshenAltar>(),
                ModContent.TileType<MonolithAmalgam>(),
                ModContent.TileType<PlagueInfuser>(),
                ModContent.TileType<VoidCondenser>(),
                ModContent.TileType<ProfanedCrucible>(),
                ModContent.TileType<BotanicPlanter>(),
                ModContent.TileType<CosmicAnvil>(),
                ModContent.TileType<SilvaBasin>(),
                ModContent.TileType<SCalAltarLarge>(),
                ModContent.TileType<DraedonsForge>()
            };
        }
    }
}
