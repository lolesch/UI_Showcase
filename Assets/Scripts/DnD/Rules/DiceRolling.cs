using DnD.Enums;
using System;

namespace DnD.Rules
{
    public abstract class DiceRolling
    {
        uint diceRollOne = 0;
        uint diceRollTwo = 0;

        private struct CheckBonuses
        {
            public uint proficiencyBonus;
            public uint total => proficiencyBonus;

            public CheckBonuses(uint proficiencyBonus = 0)
            {
                this.proficiencyBonus = proficiencyBonus;
            }
        }

        private struct CheckPenalties
        {

        }

        bool hasAdvantage = false;
        bool hasDisadvantage = false;
        bool canReroll = false;


        private bool AbilityCheck(Dice dice, uint targetNumber, Ability ability)
        {
            // roll a dice
            diceRollOne = DiceRoll(dice);
            diceRollTwo = 0;

            // if you have advantage OR disadvantage - not both!
            if (hasAdvantage && !hasDisadvantage || !hasAdvantage && hasDisadvantage)
                // roll a second dice
                diceRollTwo = DiceRoll(dice);

            // if you can reroll
            if (canReroll)
            {
                bool rerollDiceOne = true;
                // if there is a second dice to choose from
                if (0 < diceRollTwo)
                {
                    // choose a dice to reroll
                    rerollDiceOne = ChooseRerollDice();
                }
                // reroll that dice
                if (rerollDiceOne)
                    diceRollOne = DiceRoll(dice);
                else
                    diceRollTwo = DiceRoll(dice);
            }

            uint result = diceRollOne;

            // if you have advantage only
            if (hasAdvantage && !hasDisadvantage)
                // choose the higher one
                result = Math.Max(diceRollOne, diceRollTwo);

            // if you have disadvantage only
            if (!hasAdvantage && hasDisadvantage)
                // choose the lower one
                result = Math.Min(diceRollOne, diceRollTwo);

            // define the Bonuses
            CheckBonuses bonuses = new CheckBonuses();

            // perform the check
            return DiceCheck(result, ability.Modifier, targetNumber, bonuses);
        }

        public static uint DiceRoll(Dice dice)
        {
            // the player selects manual dice rolling
            if (false)
            {
                // promt the player with an input field
                // if the input value is invalid
                // promt the player with a warning and the possibility to edit or to cancle
                // return the input field's value
            }
            return (uint)UnityEngine.Random.Range(1, (int)dice);
        }

        private bool ChooseRerollDice()
        {
            // wait for the player to choose

            return false; // needs playerInput
        }

        private bool DiceCheck(uint diceRoll, int abilityMod, DifficultyClass difficultyClass, CheckBonuses bonuses)
        {
            return DiceCheck(diceRoll, abilityMod, (uint)difficultyClass, bonuses);
        }

        private bool DiceCheck(uint diceRoll, int abilityMod, uint targetNumber, CheckBonuses bonuses)
        {
            return targetNumber <= (diceRoll + abilityMod + bonuses.total);
        }
    }
}