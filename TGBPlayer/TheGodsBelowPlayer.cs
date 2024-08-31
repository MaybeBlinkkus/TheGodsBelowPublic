using Terraria.ModLoader;

namespace TheGodsBelow
{
    public partial class TheGodsBelowPlayer : ModPlayer
    {
        #region Variables
        public float lifeRatio;
        #endregion

        #region Accessory
        public bool auricCharm = false;
        public bool phoenixsBlessing = false;
        public bool serenity = false;
        #endregion

        #region Reset Effects
        public override void ResetEffects()
        {
            lifeRatio = Player.statLife / Player.statLifeMax2;
            if (auricCharm)
            {
                if (lifeRatio < 0.8)
                    Player.GetDamage<GenericDamageClass>() += 0.2f;
            }
            
            if (phoenixsBlessing)
            {
                Player.endurance += 0.05f;
                Player.GetDamage<MeleeDamageClass>() += 0.15f;
                Player.GetCritChance<MeleeDamageClass>() += 0.15f;
                Player.GetArmorPenetration<MeleeDamageClass>() += 5;
            }

            if (serenity)
            {
                Player.endurance += 0.68f; // For some reason 0.68 gives 40% DR
                Player.GetDamage<GenericDamageClass>() -= 0.8f;
                Player.GetCritChance<GenericDamageClass>() = 0;
                Player.lifeRegen -= 100;
                if (Player.lifeRegen < 0)
                    Player.lifeRegen = 0;
            }

            auricCharm = false;
            phoenixsBlessing = false;
            serenity = false;
        }
        #endregion
    }
}