using DnD.Enums;
using DnD.Races;
using System;
using TMPro;
using UnityEngine;

namespace DnD.UI.Displays
{
    public class RaceDisplay : MonoBehaviour
    {
        [SerializeField] private ColorScheme colorScheme;
        [Space]
        [SerializeField] private TMP_Text raceName;
        [SerializeField] private TMP_Text abilityScoreIncrease;
        [SerializeField] private TMP_Text adultAge;
        [SerializeField] private TMP_Text averageLifespan;
        [SerializeField] private TMP_Text alignment;
        [SerializeField] private TMP_Text size;
        [SerializeField] private TMP_Text speed;
        [SerializeField] private TMP_Text languages;

        public void UpdateDisplay(CharacterRace characterRace)
        {
            raceName.text = characterRace.RaceType.ToString();
            adultAge.text = characterRace.AdultAge.ToString();
            averageLifespan.text = characterRace.AverageLifespan.ToString();
            //alignment.text = characterRace.
            size.text = characterRace.Size.ToString();
            speed.text = characterRace.MovementSpeed.ToString();

            SetAbilityScoreText(characterRace);

            languages.text = string.Empty;
            foreach (Language language in characterRace.Languages)
            {
                languages.text += language + "\n";
            }
        }

        public void SetAbilityScoreText(CharacterRace characterRace, CharacterRace compareTo = null)
        {
            string abilityScoreText = "\n";

            int abilityCount = System.Enum.GetValues(typeof(AbilityType)).Length;

            for (int i = 0; i < abilityCount; i++)
            {
                characterRace.AbilityScoreIncrease.TryGetValue((AbilityType)i, out uint score);
                uint compareToScore = 0;
                if (compareTo != null)
                {
                    compareTo.AbilityScoreIncrease.TryGetValue((AbilityType)i, out compareToScore);
                }

                string coloredComparison = SetRichtextColor(score, compareToScore);

                // adding the score and a line break to the string
                abilityScoreText += $"{coloredComparison}\n";
            }
            abilityScoreIncrease.text = abilityScoreText;
        }

        private string SetRichtextColor(uint score, uint compareTo)
        {
            string coloredText = string.Empty;
            // decrement
            if (score < compareTo)
            {
                string coloredComparison = ColorScheme.ColoredRichText(colorScheme.tooltipDecreaseColor, $"-{compareTo - score}");
                string coloredScore = ColorScheme.ColoredRichText(colorScheme.tooltipDecreaseColor, $"{score}");

                coloredText = $"({coloredComparison})\t{coloredScore}";
            }
            // same value
            if (compareTo == score)
            {
                coloredText = $"\t{score}";
            }
            // increment
            if (compareTo < score || 0 < score)
            {
                string coloredComparison = ColorScheme.ColoredRichText(colorScheme.tooltipIncreaseColor, $"+{score - compareTo}");
                string coloredScore = ColorScheme.ColoredRichText(colorScheme.tooltipIncreaseColor, $"{score}");

                coloredText = $"({coloredComparison})\t{coloredScore}";
            }

            return coloredText;
        }

        public void UpdateDisplay(CharacterRace characterRace, CharacterRace compareRace)
        {
            UpdateDisplay(characterRace);
            SetAbilityScoreText(characterRace, compareRace);
        }
    }
}