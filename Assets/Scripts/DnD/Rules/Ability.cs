using DnD.Enums;
using System;
using UnityEngine;

namespace DnD.Rules
{
    [Serializable]
    public struct Ability
    {
        private AbilityType abilityType;
        public AbilityType AbilityType => abilityType;

        private uint score;
        public uint Score => score;

        public int Modifier => Mathf.FloorToInt((Score - 10) * .5f);

        public Ability(AbilityType abilityType, uint score)
        {
            this.abilityType = abilityType;
            this.score = (uint)Mathf.Clamp(score, 8, 20);
        }
    }
}