using DnD.Characters;
using DnD.Enums;
using System.Collections.Generic;
using UI_Showcase.Displays;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    public class SelectCharacterToggle : AbstractToggle
    {
        [SerializeField] private List<MaskableGraphic> selectedColorChangeObjects;

        [SerializeField] private SettableColor selectedColor;
        [SerializeField] private SettableColor deselectedColor;
        [SerializeField] private Sprite defaultPortrait;

        public Character character;

        protected override void OnValueChanged(bool isOn)
        {
            base.OnValueChanged(isOn);

            foreach (var item in selectedColorChangeObjects)
                item.color = isOn ? selectedColor.color : deselectedColor.color;

            if (!character)
            {
                character = ScriptableObject.CreateInstance<Character>();
                character.characterImage = defaultPortrait;
                character.characterName = "Character Name";
            }

            CharacterSelector.SetCharacter(character);
        }
    }
}
