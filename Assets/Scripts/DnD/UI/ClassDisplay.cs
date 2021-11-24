using DnD.Classes;
using TMPro;
using UnityEngine;

namespace DnD.UI.Displays
{
    public class ClassDisplay : MonoBehaviour
    {
        public TMP_Text className;
        public TMP_Text hitDice;
        public TMP_Text savingThrows;

        public void UpdateDisplay(CharacterClass characterClass)
        {
            className.text = characterClass.ClassType.ToString();
            hitDice.text = characterClass.HitDice.ToString();
            savingThrows.text = string.Empty;
            for (int i = 0; i < characterClass.savingThrowProficiencies.Count; i++)
            {
                savingThrows.text += characterClass.savingThrowProficiencies[i] + "\n";
            }
        }
    }
}