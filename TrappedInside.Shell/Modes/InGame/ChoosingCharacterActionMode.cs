using TrappedInside.Core.States.CharacterActions;
using TrappedInside.Core.States.SelectingCharacter;
using TrappedInside.Shell.ShellFunctions;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class ChoosingCharacterActionMode(CharacterActionState State, SelectingCharacterState SelectNextCharacters) : Mode
{
	public override Mode Run()
	{
		BasicShellFunctions.ClearScreen();
		BasicShellFunctions.WriteLine($"You are in {State.Location()}., and you have {State.RemainingActions} actions remaining.");
		
		BasicShellFunctions.PromptForKey();
		return new SelectingCharacterMode(SelectNextCharacters with { Data = State.Data });
	}
}