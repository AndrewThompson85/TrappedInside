using TrappedInside.Core;
using TrappedInside.Core.Characters;
using TrappedInside.Shell.ShellFunctions;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class InGameMode(GameState State) : Mode
{
	public override Mode Run()
	{
		foreach (var character in State.AliveCharacters())
		{
			BasicShellFunctions.WriteLine(character.Name);
		}

		BasicShellFunctions.PromptForKey();
		return this;
	}
}