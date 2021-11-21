using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(Button), typeof(SelectableColorsSetter))]
    public abstract class AbstractButton : MonoBehaviour
    {
        protected Button button;

        protected void Awake()
        {
            if (TryGetComponent(out button))
                button.onClick.AddListener(OnClick);
        }

        protected abstract void OnClick();
    }
}
