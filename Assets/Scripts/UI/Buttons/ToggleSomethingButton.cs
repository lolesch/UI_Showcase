using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    public class ToggleSomethingButton : AbstractButton
    {
        [SerializeField] private Toggle toggle;
        protected override void OnClick()
        {
            if (toggle)
                toggle.isOn = !toggle.isOn;
        }
    }
}
