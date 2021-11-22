using UnityEngine;

namespace UI_Showcase
{
    public class ClientCloseButton : AbstractButton
    {
        protected override void OnClick()
        {
#if UNITY_WEBGL
            Screen.fullScreen = !Screen.fullScreen;
#elif UNITY_EDITOR
            Debug.Break();
#else
            Application.Quit();
#endif
        }
    }
}
