using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(Button))]
    public abstract class AbstractButton : MonoBehaviour
    {
        protected Button button;

        [SerializeField] protected SelectableColors selectableColors;

        protected void Awake()
        {
            if (TryGetComponent(out button))
                button.onClick.AddListener(OnClick);
        }

        protected void OnValidate()
        {
            Awake();
            if (selectableColors)
                button.colors = selectableColors.colors;
        }

        protected abstract void OnClick();
    }
}
