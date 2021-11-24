using DnD.Enums;
using DnD.Races;
using UnityEngine;

namespace DnD.UI.Displays
{
    public class CharacterRaceTooltip : Tooltip
    {
        private CharacterRaceDisplay characterRaceDisplay;

        [SerializeField] private RaceDisplay raceDisplay;
        [SerializeField] private ColorScheme colorScheme;

        private void Awake() => characterRaceDisplay = compareTo.GetComponent<CharacterRaceDisplay>();

        public override void OnValueChanged(int i)
        {
            characterRaceDisplay.races.TryGetValue((RaceType)i, out CharacterRace characterRace);

            raceDisplay.UpdateDisplay(characterRace, characterRaceDisplay.CharacterRace);
        }
    }
}