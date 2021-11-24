using DnD.Characters;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase.Displays
{
    public class CharacterCardDisplay : MonoBehaviour
    {
        [SerializeField] private Image portrait;
        [SerializeField] private Sprite defaultPortrait;
        [SerializeField] private TextMeshProUGUI characterName;

        private void OnEnable()
        {
            CharacterEditorDisplay.selectedCharacter.onValueChanged += UpdateDisplay;
            UpdateDisplay(CharacterEditorDisplay.selectedCharacter);
        }

        private void OnDisable()
        {
            CharacterEditorDisplay.selectedCharacter.onValueChanged -= UpdateDisplay;
        }

        private void UpdateDisplay(Character character)
        {
            portrait.sprite = null != character ? character.characterImage : defaultPortrait;
            characterName.text = null != character ? character.characterName : "No Character selected";
        }
    }
}
