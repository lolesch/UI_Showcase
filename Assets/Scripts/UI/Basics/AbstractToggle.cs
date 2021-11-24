using DG.Tweening;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(Toggle), typeof(SelectableColorsSetter))]
    public abstract class AbstractToggle : MonoBehaviour
    {
        protected Toggle toggle;
        [SerializeField] protected bool isEnabledAtStrat = false;

        [SerializeField] protected List<GameObject> contentToToggle;

        private void Awake()
        {
            TryGetComponent(out toggle);
            toggle?.onValueChanged.AddListener(OnValueChanged);

            if (!toggle.group)
                toggle.group = GetComponentInParent<ToggleGroup>();

            toggle.isOn = isEnabledAtStrat;

            OnValueChanged(isEnabledAtStrat);
        }

        protected virtual void OnValueChanged(bool isOn)
        {
            foreach (var item in contentToToggle)
                item.SetActive(isOn);
        }
    }
}
