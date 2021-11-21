using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI_Showcase
{
    public class SelectCharacterButton : AbstractToggle
    {
        [SerializeField] private List<Image> selectedColorChangeObjects;
        [SerializeField] private List<Image> selectedSecondColorChangeObjects;
        [SerializeField] private Color selectedColor;
        [SerializeField] private Color selectedSecondColor;
        [SerializeField] private Color deselectedColor;

        protected override void OnValueChanged(bool isOn)
        {
            foreach (var item in selectedColorChangeObjects)
                item.color = isOn ? selectedColor : deselectedColor;

            foreach (var item in selectedSecondColorChangeObjects)
                item.color = isOn ? selectedSecondColor : deselectedColor;
        }
    }
}
