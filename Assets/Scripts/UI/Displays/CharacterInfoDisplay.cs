using DnD.Characters;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase.Displays
{
    public class CharacterInfoDisplay : MonoBehaviour
    {
        [SerializeField] private Image portrait;
        [SerializeField] private TextMeshProUGUI characterName;
        [SerializeField] private TextMeshProUGUI characterLevel;
        [SerializeField] private TextMeshProUGUI characterRace;
        [SerializeField] private Slider levelSlider;

        private void Awake()
        {
            CharacterSelector.onValueChanged += UpdateDisplay;
        }
        private void OnDestroy()
        {
            CharacterSelector.onValueChanged -= UpdateDisplay;
        }

        private void UpdateDisplay(Character character)
        {
            if (portrait)
                portrait.sprite = character.characterImage;
            if (characterName)
                characterName.text = character.characterName;
            if (characterLevel)
                characterLevel.text = character.CharacterLevel.ToString();
            if (characterRace)
                characterRace.text = character.CharacterRace ? character.CharacterRace?.RaceType.ToString() : "No race selected";
            if (levelSlider)
                levelSlider.value = Random.Range(0f, 1f);
        }
    }
}
