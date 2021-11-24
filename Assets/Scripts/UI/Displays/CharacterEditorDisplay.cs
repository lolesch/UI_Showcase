using DnD.Characters;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UI_Showcase.Displays
{
    public class CharacterEditorDisplay : MonoBehaviour
    {
        public static Character selectedCharacter;
        [SerializeField] private Character newDefaultCharacter;

        [SerializeField] private TMP_InputField characterName;

        private void Awake()
        {
            selectedCharacter = newDefaultCharacter;
        }

        private void OnEnable()
        {
            characterName.onSubmit.AddListener(selectedCharacter.SetCharacterName);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            characterName.text = selectedCharacter.characterName;
        }

        //private void SetCharacter(Character character) => this.character = character;

    }
}
