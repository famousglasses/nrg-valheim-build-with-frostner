using BepInEx;
using BepInEx.Configuration;
using System.IO;

namespace BuildWithFrostner {
	[BepInPlugin("nrg.valheim.buildwithfrostner", "BuildWithFrostner", "1.0.0")]
	public class BuildWithFrostner : BaseUnityPlugin {
		private ConfigEntry<string> cfgKey;

		private void Awake() {
			cfgKey = Config.Bind(
				"General", // config section
				"Toggle Key", // config key
				"Alt", // default value
				"Control which key will toggle Frostner between attack and build modes" // config description
			);
		}
	}
}
