using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(Toggle))]
    public abstract class AbstractToggle : MonoBehaviour
    {
        protected Toggle toggle;

        [SerializeField] protected GameObject contentToToggle;

        [SerializeField] protected SelectableColors selectableColors;

        private void Awake()
        {
            TryGetComponent(out toggle);
            toggle?.onValueChanged.AddListener(OnValueChanged);
        }

        protected void OnValidate()
        {
            Awake();
            if (selectableColors)
                toggle.colors = selectableColors.colors;
        }

        protected virtual void OnValueChanged(bool isOn)
        {
            if (contentToToggle)
                contentToToggle.SetActive(isOn);
        }
    }
}
