using Spectre.Console;
using TrappedInside.Core;
using TrappedInside.Core.Characters;
using TrappedInside.Core.States.CharacterActions;
using TrappedInside.Core.States.SelectingCharacter;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class SelectingCharacterMode(SelectingCharacterState State) : Mode
{
	public override Mode Run()
	{
		switch (State)
		{
			case CharactersAvailableState charactersAvailableState:
				var selectedCharacter = SelectCharacterWidget(charactersAvailableState);
				return new ChoosingCharacterActionMode(CharacterActionState.New(State.Data, selectedCharacter), charactersAvailableState.MarkAsPlayed(selectedCharacter));
			case NoCharactersAvailableState noCharactersAvailable:
				return new EndOfTurnMode(noCharactersAvailable.Data);
			default:
				throw new ArgumentOutOfRangeException(nameof(State));
		}
	}

	private static CharacterId SelectCharacterWidget(CharactersAvailableState charactersAvailableState)
	{
		return AnsiConsole.Prompt(new SelectionPrompt<CharacterId>()
			.Title("Which Character do you want to play next?")
			.PageSize(4)
			.AddChoices(charactersAvailableState.CharactersAvailableForSelection())
			.UseConverter(c => c.Name()));
	}
}