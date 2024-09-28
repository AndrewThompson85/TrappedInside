using TrappedInside.Core;
using TrappedInside.Core.States;
using static TrappedInside.Shell.ShellFunctions.BasicShellFunctions;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class SelectingCharacterMode(SelectingCharacterState State) : Mode
{
	public override Mode Run()
	{
		WriteLine("Selecting character state");
		foreach (var character in State.AvailableChoices)
		{
			WriteLine(character.Name());
		}
		
		PromptForKey();
		return this;
	}
}