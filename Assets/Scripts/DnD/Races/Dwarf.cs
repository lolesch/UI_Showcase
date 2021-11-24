using DnD.Enums;
using DnD.Rules;

namespace DnD.Races
{
    public class Dwarf : CharacterRace
    {
        // DwarvenResilience
        // DwarvenCombatTraining
        // ToolProficiency
        // Stonecunning

        public enum DwarfMaleName
        {
            Adrik,
            Alberich,
            Baern,
            Barendd,
            Brottor,
            Bruenor,
            Dain,
            Darrak,
            Delg,
            Eberk,
            Einkil,
            Fargrim,
            Flint,
            Gardain,
            Harbek,
            Kildrak,
            Morgran,
            Orsik,
            Oskar,
            Rangrim,
            Rurik,
            Taklinn,
            Thoradin,
            Thorin,
            Tordek,
            Traubon,
            Travok,
            Ulfgar,
            Veit,
            Vondal,
        }
        public enum DwarfFemaleName
        {
            Amber,
            Artin,
            Audhild,
            Bardryn,
            Dagnal,
            Diesa,
            Eldeth,
            Falkrunn,
            Finellen,
            Gunnloda,
            Gurdis,
            Helja,
            Hlin,
            Kathra,
            Kristryd,
            Ilde,
            Liftrasa,
            Mardred,
            Riswynn,
            Sannl,
            Torbera,
            Torgga,
            Vistra,
        }
        public enum DwarfClanName
        {
            Balderk,
            Battlehammer,
            Brawnanvil,
            Dankil,
            Fireforge,
            Frostbeard,
            Gorunn,
            Holderhek,
            Ironfist,
            Loderr,
            Lutgehr,
            Rumnaheim,
            Strakeln,
            Torunn,
            Ungart
        }
    }

    public class HillDwarf : Dwarf
    {
        //abilityScoreIncrease.Clear();
        //abilityScoreIncrease.Add(AbilityType.Wisdom, 1u);

        // DwarvenToughness        
    }

    public class MountainDwarf : Dwarf
    {
        //abilityScoreIncrease.Clear();
        //abilityScoreIncrease.Add(AbilityType.Strength, 2u);

        // DwarvenArmorTraining        
    }
}