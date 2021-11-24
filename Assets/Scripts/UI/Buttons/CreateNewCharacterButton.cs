﻿using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    public class CreateNewCharacterButton : AbstractButton
    {
        [SerializeField] private GameObject characterPrefab;
        [SerializeField] private ToggleGroup group;
        protected override void OnClick()
        {
            GameObject newCharacter = Instantiate(characterPrefab, group.transform);
            if (newCharacter.TryGetComponent(out Toggle toggle))
            {
                toggle.group = group;
                toggle.isOn = true;
                toggle.Select();
            }
            newCharacter.transform.SetSiblingIndex(0);
        }
    }
}