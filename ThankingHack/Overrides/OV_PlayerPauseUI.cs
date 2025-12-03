using System.Reflection;
using SDG.Unturned;
using Thanking.Attributes;

namespace Thanking.Overrides;

public static class OV_PlayerPauseUI
{
    [Override(typeof(PlayerPauseUI), "onClickedExitButton", BindingFlags.NonPublic | BindingFlags.Static)]
#pragma warning disable IDE0060
    public static void OV_onClickedExitButton(ISleekElement button) => Provider.disconnect();
#pragma warning restore IDE0060
}
