using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DnD.UI.Displays
{
    [RequireComponent(typeof(RectTransform))]
    public class DropdownItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
    {
        [SerializeField] private Tooltip tooltip;
        [SerializeField] private TMP_Text itemLabel;
        public void OnPointerEnter(PointerEventData eventData)
        {
            tooltip.OnValueChanged(transform.GetSiblingIndex() - 1);
            tooltip.FadeIn();
            itemLabel.DOFade(1, .2f).SetEase(Ease.InCubic);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            tooltip.FadeOut();
            itemLabel.DOFade(0, .2f).SetEase(Ease.OutCubic);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            tooltip.FadeOut();
            itemLabel.DOFade(0, .2f).SetEase(Ease.OutCubic);
        }
    }
}