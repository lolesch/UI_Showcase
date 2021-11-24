using DnD.Enums;
using DnD.Races;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DnD.UI.Displays
{
    public class CharacterRaceDisplay : SerializedMonoBehaviour
    {
        private CharacterRace characterRace;
        public CharacterRace CharacterRace => characterRace;

        [SerializeField] private RaceDisplay raceDisplay;
        [Space]
        [SerializeField] private TMP_Dropdown raceDropdown;

        public Dictionary<RaceType, CharacterRace> races = new Dictionary<RaceType, CharacterRace> { };

        private void Awake() => SetupRaceDropdown();

        private void Start()
        {
            SetValues();
        }

        private void SetupRaceDropdown()
        {
            raceDropdown.onValueChanged.AddListener(delegate { SetValues(); });

            int raceCount = System.Enum.GetValues(typeof(RaceType)).Length;

            for (int i = 0; i < raceCount; i++)
            {
                races.TryGetValue((RaceType)i, out characterRace);

                raceDropdown.options.Add(new TMP_Dropdown.OptionData()
                {
                    text = System.Enum.GetName(typeof(RaceType), (RaceType)i),
                    image = CharacterRace.RaceIcon,
                }
                );
            }
        }

        private void SetValues()
        {
            races.TryGetValue((RaceType)raceDropdown.value, out characterRace);

            raceDisplay.UpdateDisplay(characterRace);
        }
    }
}