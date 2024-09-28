using TrappedInside.Core;
using TrappedInside.Core.Characters;
using TrappedInside.Core.States;
using TrappedInside.Core.States.SelectingCharacter;
using TrappedInside.Shell.ShellFunctions;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class InGameMode : Mode
{
	public State State;

	public InGameMode(NewTurnState state)
	{
		State = state;
	}

	public override Mode Run()
	{
		return State switch
		{
			NewTurnState newTurnState => new NewTurnMode(newTurnState),
			SelectingCharacterState selectingCharacterState => new SelectingCharacterMode(selectingCharacterState),
			_ => throw new ArgumentOutOfRangeException(nameof(State))
		};
	}
}