using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(Toggle))]
    public abstract class AbstractToggle : MonoBehaviour
    {
        protected Toggle toggle;

        private void Awake()
        {
            TryGetComponent(out toggle);
            toggle?.onValueChanged.AddListener(OnClick);
        }

        protected abstract void OnClick(bool isOn);
    }
}
