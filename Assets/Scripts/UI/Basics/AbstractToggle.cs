using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(Toggle), typeof(SelectableColorsSetter))]
    public abstract class AbstractToggle : MonoBehaviour
    {
        protected Toggle toggle;

        [SerializeField] protected GameObject contentToToggle;

        private void Awake()
        {
            TryGetComponent(out toggle);
            toggle?.onValueChanged.AddListener(OnValueChanged);
        }

        protected virtual void OnValueChanged(bool isOn)
        {
            if (contentToToggle)
                contentToToggle.SetActive(isOn);
        }
    }
}
