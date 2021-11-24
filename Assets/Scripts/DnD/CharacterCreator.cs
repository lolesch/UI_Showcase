using UnityEngine;
using System.Collections.Generic;
using DnD.Rules;
using System.Linq;
using DnD.Enums;

namespace DnD.Characters
{
    public class CharacterCreator : MonoBehaviour
    {
        private Character character = new Character();

        //[SerializeField] private CharacterClassDisplay characterClassDisplay;

        //[SerializeField] private TMP_InputField nameInputField;
        //[SerializeField] private TMP_InputField levelInputField;
        //[SerializeField] private TMP_Dropdown raceDropdown;
        //[SerializeField] private TMP_Dropdown subRaceDropdown;
        //[SerializeField] private TMP_Dropdown subClassDropdown;


        //private void SetupRaceDropdown()
        //{
        //    //raceDropdown.onValueChanged.AddListener(delegate { SetCharacterRace(); });
        //    raceDropdown.options.Clear();
        //
        //    int races = System.Enum.GetValues(typeof(CharacterRace)).Length;
        //
        //    for (int i = 0; i < races; i++)
        //    {
        //        raceDropdown.options.Add(new TMP_Dropdown.OptionData() { text = System.Enum.GetName(typeof(CharacterRace), (CharacterRace)i) });
        //    }
        //}

        //private void SetCharacterRace() => character.SetCharacterRace((CharacterRace)raceDropdown.value);

        public void GenerateRandomAbilityScores()
        {
            uint[] scores = new uint[6];
            for (int i = 0; i < scores.Length; i++)
            {
                List<uint> diceRolls = new List<uint>();

                for (int j = 0; j < 4; j++)
                    diceRolls.Add(DiceRolling.DiceRoll(Dice.d6));

                // visualize all 4 rolls, than remove the lowest
                diceRolls.Remove(diceRolls.AsQueryable().Min());

                uint sum = 0;
                foreach (var diceRoll in diceRolls)
                    sum += diceRoll;

                scores[i] = sum;
            }
            // choose what score goes on what ability
        }

        private void GenerateDefaultAbilityScores()
        {
            uint[] scores = new uint[6];
            for (int i = 0; i < scores.Length; i++)
                scores[i] = (uint)(8 + i);
            // choose what score goes on what ability
        }

        private void GenerateCustomAbilityScores()
        {
            uint[] scores = new uint[6];
            for (int i = 0; i < scores.Length; i++)
                scores[i] = 8u;

            // uint pointsToSpend = 27u;
            // UI to add/remove points between 8 and 15
            // spend/gain 2 points at 13 <--> 14 and 14 <--> 15
        }
    }
}