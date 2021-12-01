using DG.Tweening;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase.Animations
{
    public class LoginAnimation : AbstractButton
    {
        [SerializeField] private TextMeshProUGUI title;
        [SerializeField] private LayoutElement headerElement;

        [SerializeField] private List<CanvasGroup> objectsToTurnOn;

        protected override void OnClick()
        {
            foreach (var item in objectsToTurnOn)
                DOTween.Sequence().Insert(.5f, item.DOFade(1f, .2f));

            // fade out title
            title.DOFade(0f, .2f);
            // scale down header
            headerElement.DOPreferredSize(new Vector2(1920f, 100f), .5f);
            // fade out content


            // fade in header content
            // fade in content
        }
    }
}
