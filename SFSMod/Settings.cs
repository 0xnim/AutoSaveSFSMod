using ModLoader;
using SFS.Input;
using UnityEngine;

namespace AutoSave
{
	public class Settings : ModKeybindings
	{


		public static Settings Main;

		public static void Setup()
		{
			// Again for the singleton pattern. To use keybindings values anywhere in your mod.
			Main = SetupKeybindings<Settings>(MyMod.Main);
		}

		public override void CreateUI()
		{
			// this sections load default keybindings
			 Settings keySettings = new Settings();

			// this creates UI elements in the Settings menu
			base.CreateUI_Text("AutoSaver");
			base.CreateUI_Keybinding(ASMin, keySettings.Test, "AutoSave Invertal Minutes");

        }

		// define your key bindings like this
		public KeybindingsPC.Key ASMin = KeyCode.H;
    }
}
