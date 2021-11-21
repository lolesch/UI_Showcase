using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [CreateAssetMenu(fileName = "new ColorBlock", menuName = "ScriptableObjects/UI/ColorBlock")]
    public class SelectableColors : ScriptableObject
    {
        public ColorBlock colors = ColorBlock.defaultColorBlock;
    }
}
