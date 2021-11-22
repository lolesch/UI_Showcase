using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    public class SelectCharacterToggle : AbstractToggle
    {
        [SerializeField] private List<MaskableGraphic> selectedColorChangeObjects;

        [SerializeField] private SettableColor selectedColor;
        [SerializeField] private SettableColor deselectedColor;

        protected override void OnValueChanged(bool isOn)
        {
            foreach (var item in selectedColorChangeObjects)
                item.color = isOn ? selectedColor.color : deselectedColor.color;
        }

        [ContextMenu("Validate")]
        private void OnValidate()
        {
            if (TryGetComponent(out toggle))
                OnValueChanged(toggle.isOn);
        }
    }
}
