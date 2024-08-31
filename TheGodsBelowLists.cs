using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.Other;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.PrimordialWyrm;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.Yharon;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGodsBelow
{
    public class TheGodsBelowLists
    {
        public static List<int> bossesList;

        public static void LoadLists()
        {
            bossesList = new List<int>()
            {
                NPCID.KingSlime,
                NPCID.EyeofCthulhu,
                NPCID.EaterofWorldsBody,
                NPCID.EaterofWorldsHead,
                NPCID.EaterofWorldsTail,
                NPCID.BrainofCthulhu,
                NPCID.QueenBee,
                NPCID.Skeleton,
                NPCID.Deerclops,
                NPCID.WallofFlesh,
                NPCID.QueenSlimeBoss,
                NPCID.Retinazer,
                NPCID.Spazmatism,
                NPCID.TheDestroyer,
                NPCID.TheDestroyerBody,
                NPCID.TheDestroyerTail,
                NPCID.PrimeCannon,
                NPCID.PrimeLaser,
                NPCID.PrimeSaw,
                NPCID.PrimeVice,
                NPCID.SkeletronPrime,
                NPCID.Plantera,
                NPCID.Golem,
                NPCID.GolemFistLeft,
                NPCID.GolemFistRight,
                NPCID.GolemHead,
                NPCID.GolemHeadFree,
                NPCID.DukeFishron,
                NPCID.HallowBoss,
                NPCID.CultistBoss,
                NPCID.CultistBossClone,
                NPCID.MoonLordCore,
                NPCID.MoonLordFreeEye,
                NPCID.MoonLordHead,
                NPCID.MoonLordHand,
                ModContent.NPCType<DesertScourgeBody>(),
                ModContent.NPCType<DesertScourgeHead>(),
                ModContent.NPCType<DesertScourgeTail>(),
                ModContent.NPCType<Crabulon>(),
                ModContent.NPCType<HiveMind>(),
                ModContent.NPCType<PerforatorHive>(),
                ModContent.NPCType<PerforatorBodyLarge>(),
                ModContent.NPCType<PerforatorBodyMedium>(),
                ModContent.NPCType<PerforatorBodySmall>(),
                ModContent.NPCType<PerforatorHeadLarge>(),
                ModContent.NPCType<PerforatorHeadMedium>(),
                ModContent.NPCType<PerforatorHeadSmall>(),
                ModContent.NPCType<PerforatorTailLarge>(),
                ModContent.NPCType<PerforatorTailMedium>(),
                ModContent.NPCType<PerforatorTailSmall>(),
                ModContent.NPCType<CrimulanPaladin>(),
                ModContent.NPCType<EbonianPaladin>(),
                ModContent.NPCType<SlimeGodCore>(),
                ModContent.NPCType<Cryogen>(),
                ModContent.NPCType<AquaticScourgeBody>(),
                ModContent.NPCType<AquaticScourgeBodyAlt>(),
                ModContent.NPCType<AquaticScourgeHead>(),
                ModContent.NPCType<AquaticScourgeTail>(),
                ModContent.NPCType<BrimstoneElemental>(),
                ModContent.NPCType<CalamitasClone>(),
                ModContent.NPCType<Leviathan>(),
                ModContent.NPCType<Anahita>(),
                ModContent.NPCType<AstrumAureus>(),
                ModContent.NPCType<PlaguebringerGoliath>(),
                ModContent.NPCType<RavagerBody>(),
                ModContent.NPCType<RavagerClawLeft>(),
                ModContent.NPCType<RavagerClawRight>(),
                ModContent.NPCType<RavagerHead>(),
                ModContent.NPCType<RavagerHead2>(),
                ModContent.NPCType<RavagerLegLeft>(),
                ModContent.NPCType<RavagerLegRight>(),
                ModContent.NPCType<ProfanedGuardianCommander>(),
                ModContent.NPCType<ProfanedGuardianDefender>(),
                ModContent.NPCType<ProfanedGuardianHealer>(),
                ModContent.NPCType<Bumblefuck>(),
                ModContent.NPCType<Bumblefuck2>(),
                ModContent.NPCType<Providence>(),
                ModContent.NPCType<StormWeaverBody>(),
                ModContent.NPCType<StormWeaverHead>(),
                ModContent.NPCType<StormWeaverTail>(),
                ModContent.NPCType<CeaselessVoid>(),
                ModContent.NPCType<Signus>(),
                ModContent.NPCType<Polterghast>(),
                ModContent.NPCType<OldDuke>(),
                ModContent.NPCType<DevourerofGodsBody>(),
                ModContent.NPCType<DevourerofGodsHead>(),
                ModContent.NPCType<DevourerofGodsTail>(),
                ModContent.NPCType<CosmicGuardianBody>(),
                ModContent.NPCType<CosmicGuardianHead>(),
                ModContent.NPCType<CosmicGuardianTail>(),
                ModContent.NPCType<Yharon>(),
                ModContent.NPCType<AresBody>(),
                ModContent.NPCType<AresGaussNuke>(),
                ModContent.NPCType<AresLaserCannon>(),
                ModContent.NPCType<AresPlasmaFlamethrower>(),
                ModContent.NPCType<AresTeslaCannon>(),
                ModContent.NPCType<ThanatosBody1>(),
                ModContent.NPCType<ThanatosBody2>(),
                ModContent.NPCType<ThanatosHead>(),
                ModContent.NPCType<ThanatosTail>(),
                ModContent.NPCType<SupremeCalamitas>(),
                ModContent.NPCType<PrimordialWyrmBody>(),
                ModContent.NPCType<PrimordialWyrmBodyAlt>(),
                ModContent.NPCType<PrimordialWyrmHead>(),
                ModContent.NPCType<PrimordialWyrmTail>(),
                ModContent.NPCType<THELORDE>()
            };
        }
    }
}
