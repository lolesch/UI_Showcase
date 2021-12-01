using DnD.Characters;
using UnityEngine;
using TMPro;

namespace UI_Showcase.Displays
{
    public class CharacterEditorDisplay : MonoBehaviour
    {
        [SerializeField] private Character newDefaultCharacter;

        [SerializeField] private TMP_InputField characterName;


        private void Awake()
        {
            characterName.onSubmit.AddListener(CharacterSelector.selectedCharacter.SetCharacterName);
            CharacterSelector.onValueChanged += UpdateDisplay;
        }

        private void OnDestroy()
        {
            characterName.onSubmit.RemoveListener(CharacterSelector.selectedCharacter.SetCharacterName);
            CharacterSelector.onValueChanged -= UpdateDisplay;
        }

        private void UpdateDisplay(Character character)
        {
            characterName.text = CharacterSelector.selectedCharacter.characterName;
        }

    }
}
