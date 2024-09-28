using Spectre.Console;
using TrappedInside.Core;
using TrappedInside.Core.Characters;
using TrappedInside.Core.States.SelectingCharacter;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class SelectingCharacterMode(SelectingCharacterState State) : Mode
{
	public override Mode Run()
	{
		var selectedCharacter = AnsiConsole.Prompt(new SelectionPrompt<CharacterId>()
			.Title("Which Character do you want to play next?")
			.PageSize(4)
			.AddChoices(State.CharactersAvailableForSelection())
			.UseConverter(c => c.Name()));
		
		return new SelectingCharacterMode(State.MarkAsPlayed(selectedCharacter));
	}
}