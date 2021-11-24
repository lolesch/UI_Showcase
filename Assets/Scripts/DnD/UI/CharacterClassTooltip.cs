using DnD.Classes;
using DnD.Enums;
using UnityEngine;

namespace DnD.UI.Displays
{
    public class CharacterClassTooltip : Tooltip
    {
        private CharacterClassDisplay characterClassDisplay;

        [SerializeField] private ClassDisplay classDisplay;
        [SerializeField] private ColorScheme colorScheme;


        private void Awake() => characterClassDisplay = compareTo.GetComponent<CharacterClassDisplay>();

        public override void OnValueChanged(int i)
        {
            characterClassDisplay.classes.TryGetValue((ClassType)i, out CharacterClass characterClass);

            classDisplay.UpdateDisplay(characterClass);
            if (characterClass.HitDice == characterClassDisplay.CharacterClass.HitDice)
            {
                classDisplay.hitDice.color = colorScheme.tooltipTextColor;
            }
            else
            {
                Color color = characterClass.HitDice < characterClassDisplay.CharacterClass.HitDice
                    ? colorScheme.tooltipDecreaseColor
                    : colorScheme.tooltipIncreaseColor;
                classDisplay.hitDice.color = color;
            }
        }
    }
}