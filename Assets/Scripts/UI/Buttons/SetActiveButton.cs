using System.Collections.Generic;
using UnityEngine;

namespace UI_Showcase
{
    public class SetActiveButton : AbstractButton
    {
        [SerializeField] private List<GameObject> objectsToTurnOn;
        [SerializeField] private List<GameObject> objectsToTurnOff;
        protected override void OnClick()
        {
            foreach (var item in objectsToTurnOff)
                item.SetActive(false);

            foreach (var item in objectsToTurnOn)
                item.SetActive(true);
        }
    }
}
