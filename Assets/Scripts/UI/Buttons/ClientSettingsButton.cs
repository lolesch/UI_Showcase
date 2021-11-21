using System.Collections.Generic;
using UnityEngine;

namespace UI_Showcase
{
    public class ClientSettingsButton : AbstractButton
    {
        [SerializeField] private List<GameObject> objectsToEnable;
        protected override void OnClick()
        {
            foreach (var item in objectsToEnable)
                item.SetActive(true);
        }
    }
}
