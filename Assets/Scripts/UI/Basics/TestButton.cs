using UnityEngine;

namespace UI_Showcase
{
    public class TestButton : AbstractButton
    {
        protected override void OnClick() => Debug.Log($"{name} was clicked");
    }
}
