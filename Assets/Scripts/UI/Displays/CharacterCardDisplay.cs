using DnD.Characters;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase.Displays
{
    public class CharacterCardDisplay : MonoBehaviour
    {
        [SerializeField] private Image portrait;
        [SerializeField] private TextMeshProUGUI characterName;

        private void Awake()
        {
            if (TryGetComponent(out SelectCharacterToggle characterToggle))
                UpdateDisplay(characterToggle.character);
        }

        private void UpdateDisplay(Character character)
        {
            portrait.sprite = character.characterImage;
            characterName.text = character.characterName;
        }
    }
}
