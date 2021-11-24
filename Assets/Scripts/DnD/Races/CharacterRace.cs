using DnD.Enums;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace DnD.Races
{
    [CreateAssetMenu(fileName = "new RaceValues", menuName = "Character/RaceValuse", order = 1)]
    public class CharacterRace : SerializedScriptableObject
    {
        [SerializeField] private RaceType raceType;
        public RaceType RaceType => raceType;

        [SerializeField] private Sprite raceIcon;
        public Sprite RaceIcon => raceIcon;

        [SerializeField]
        private Dictionary<AbilityType, uint> abilityScoreIncrease = new Dictionary<AbilityType, uint>()
        {
            { AbilityType.Charisma, 0 },
            { AbilityType.Constitution, 0 },
            { AbilityType.Dexterity, 0 },
            { AbilityType.Intelligence, 0 },
            { AbilityType.Strength, 0 },
            { AbilityType.Wisdom, 0 },
        };

        public Dictionary<AbilityType, uint> AbilityScoreIncrease => abilityScoreIncrease;

        [SerializeField] private uint adultAge;
        public uint AdultAge => adultAge;

        [SerializeField] private uint averageLifespan;
        public uint AverageLifespan => averageLifespan;

        [SerializeField] private Alignment alignment;

        [SerializeField] private CharacterSize size;
        public CharacterSize Size => size;

        // speed
        // DWARF: not reduced by heavy armor
        [SerializeField] private uint movementSpeed;
        public uint MovementSpeed => movementSpeed;

        [SerializeField] private List<Language> languages = new List<Language>();
        public List<Language> Languages => languages;

        // TODO: subraces
        // subraces inherit from the parent race

        [SerializeField] private List<Spell> spells = new List<Spell>();

        // TODO: race specific extras
        // DWARF:
        // DwarvenResilience
        // DwarvenCombatTraining
        // ToolProficiency
        // Stonecunning
    }
}