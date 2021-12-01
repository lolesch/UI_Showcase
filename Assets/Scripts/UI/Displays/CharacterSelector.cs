using DnD.Characters;
using System;

namespace UI_Showcase.Displays
{
    public static class CharacterSelector
    {
        public static Character selectedCharacter;
        public static event Action<Character> onValueChanged;

        public static void SetCharacter(Character character)
        {
            selectedCharacter = character;
            UpdateCharacter();
        }

        private static void UpdateCharacter() => onValueChanged?.Invoke(selectedCharacter);
    }
}
