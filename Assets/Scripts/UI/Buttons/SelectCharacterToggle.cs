using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    public class SelectCharacterToggle : AbstractToggle
    {
        [SerializeField] private List<MaskableGraphic> selectedLightColorChangeObjects;
        [SerializeField] private List<MaskableGraphic> selectedDarkColorChangeObjects;

        [SerializeField] private SettableColor selectedLightColor;
        [SerializeField] private SettableColor selectedDarkColor;
        [SerializeField] private SettableColor deselectedColor;

        protected override void OnValueChanged(bool isOn)
        {
            foreach (var item in selectedLightColorChangeObjects)
                item.color = isOn ? selectedLightColor.color : deselectedColor.color;

            foreach (var item in selectedDarkColorChangeObjects)
                item.color = isOn ? selectedDarkColor.color : deselectedColor.color;
        }

        private void OnValidate()
        {
            if (TryGetComponent(out toggle))
                OnValueChanged(toggle.isOn);
        }
    }
}
