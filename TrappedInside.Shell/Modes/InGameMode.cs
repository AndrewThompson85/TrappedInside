using TrappedInside.Core;
using TrappedInside.Core.Characters;
using TrappedInside.Shell.ShellFunctions;

namespace TrappedInside.Shell.Modes;

public sealed class InGameMode : Mode
{
	public readonly GameState State;

	public InGameMode(GameState state)
	{
		State = state;
	}

	public override Mode Run()
	{
		foreach (var character in State.Characters.Where(c => c is AliveCharacter))
		{
			BasicShellFunctions.WriteLine(character.Name);
		}

		BasicShellFunctions.PromptForKey();
		return this;
	}
}