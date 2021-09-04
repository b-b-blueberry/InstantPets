using StardewModdingAPI;
using System;

namespace InstantPets
{
	public interface IGenericModConfigMenuAPI
	{
		void RegisterModConfig(IManifest mod, Action revertToDefault, Action saveToFile);
		void SetDefaultIngameOptinValue(IManifest mod, bool optedIn);
		void RegisterSimpleOption(IManifest mod, string optionName, string optionDesc, Func<bool> optionGet, Action<bool> optionSet);
	}
}
