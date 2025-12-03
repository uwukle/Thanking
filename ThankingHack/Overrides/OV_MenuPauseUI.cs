using System.Reflection;
using SDG.Unturned;
using Thanking.Attributes;
using UnityEngine;

namespace Thanking.Overrides;

public static class OV_MenuPauseUI
{
	[Override(typeof(MenuPauseUI), "onClickedExitButton", BindingFlags.NonPublic | BindingFlags.Static)]
#pragma warning disable IDE0060
    public static void OV_onClickedExitButton(ISleekElement button) => Application.Quit();
#pragma warning restore IDE0060
}
