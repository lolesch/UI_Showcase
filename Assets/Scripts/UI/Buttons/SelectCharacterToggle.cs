using DnD.Characters;
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

        [SerializeField] private Character character;

        protected override void OnValueChanged(bool isOn)
        {
            foreach (var item in selectedColorChangeObjects)
                item.color = isOn ? selectedColor.color : deselectedColor.color;

            CharacterEditorDisplay.selectedCharacter = character;
        }
    }
}
