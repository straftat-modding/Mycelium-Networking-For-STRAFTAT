using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyceliumNetworking.Patches
{
	[HarmonyPatch(typeof(SteamLobby))]
	internal class SteamLobbyPatch
	{
		[HarmonyPatch(nameof(SteamLobby.LeaveSteamLobby))]
		[HarmonyPostfix]
		static void LeaveLobbyPatch()
		{
			MyceliumNetwork.OnLobbyLeft();
		}
	}
}
