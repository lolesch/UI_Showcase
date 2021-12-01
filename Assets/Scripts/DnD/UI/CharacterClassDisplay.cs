using DnD.Classes;
using DnD.Enums;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UI_Showcase.Displays;

namespace DnD.UI.Displays
{
    public class CharacterClassDisplay : SerializedMonoBehaviour
    {
        private CharacterClass characterClass;
        public CharacterClass CharacterClass => characterClass;

        [SerializeField] private ClassDisplay classDisplay;
        [Space]
        [SerializeField] private TMP_Dropdown classDropdown;

        public Dictionary<ClassType, CharacterClass> classes = new Dictionary<ClassType, CharacterClass>() { };

        private void Awake() => SetupClassDropdown();

        private void Start()
        {
            SetValues();
        }

        private void SetupClassDropdown()
        {
            classDropdown.onValueChanged.AddListener(delegate { SetValues(); });

            int classCount = System.Enum.GetValues(typeof(ClassType)).Length;

            for (int i = 0; i < classCount; i++)
            {
                classes.TryGetValue((ClassType)i, out characterClass);

                // get all classes.Values, sort them, then add all to the dropdown.options

                classDropdown.options.Add(new TMP_Dropdown.OptionData()
                {
                    text = System.Enum.GetName(typeof(ClassType), (ClassType)i),
                    image = CharacterClass.ClassIcon,
                }
                );
            }
        }

        private void SetValues()
        {
            classes.TryGetValue((ClassType)classDropdown.value, out characterClass);

            classDisplay.UpdateDisplay(characterClass);

            CharacterSelector.selectedCharacter.SetCharacterClass(characterClass, 0);
        }
    }
}