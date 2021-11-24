using DnD.Enums;
using System.Collections.Generic;
using UnityEngine;

namespace DnD.Characters
{
    [CreateAssetMenu(fileName = "new Background", menuName = "Character/Background", order = 1)]
    public class CharacterBackground : ScriptableObject
    {
        // skill proficiencies
        private List<Skill> skills = new List<Skill>(2);
        // tool proficiencies
    }
}