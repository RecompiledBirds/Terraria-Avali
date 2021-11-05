//make sure to add "modReferences = MrPlagueRaces" into your mod's Build.txt
using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace AvaliMod
{
    [Label("Avali Mod Settings")]
    public class AvaliModConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(true)]
        [LabelAttribute("Avali have darkness debuff:")]
        public bool DarknessEnabled;

        [DefaultValue(true)]
        [LabelAttribute("Avali can hear enemies in the dark:")]
        public bool CanHearInDark;

        [DefaultValue(true)]
        [LabelAttribute("Avali can glide:")]
        public bool HasGlidingAbility;

        [DefaultValue(true)]
        [LabelAttribute("Racial key is toggle:")]
        public bool RacialKeyIsToggle;

        [DefaultValue(false)]
        [Label("Avali have modified stats:")]
        public bool AvaliHaveModifiedStats;

    }
    public class AvaliMod : Mod
    {   
        public static AvaliMod Instance { get; private set; }
        public override void Load()
        {
            //this is essential, loads this mod's custom races
            MrPlagueRaces.Core.Loadables.LoadableManager.Autoload(this);
        }
        public override void Unload()
        {
            //this is essential, unloads this mod's custom races
            MrPlagueRaces.Common.Races.RaceLoader.Races.Clear();
            MrPlagueRaces.Common.Races.RaceLoader.RacesByLegacyIds.Clear();
            MrPlagueRaces.Common.Races.RaceLoader.RacesByFullNames.Clear();
        }
    }
}