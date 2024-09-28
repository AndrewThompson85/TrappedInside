using System.Collections.Immutable;
using TrappedInside.Core.Characters;

namespace TrappedInside.Core.States.SelectingCharacter;

public static class SelectingCharacterStateFunctions
{
	public static ImmutableArray<CharacterId> CharactersAvailableForSelection(this CharactersAvailableState state) => [..
		from character in CharacterFunctions.AllCharacters
		where state.Data.AliveCharacters().Ids().Contains(character)
		where state.PlayedCharacters.Contains(character) == false
		select character];

	public static SelectingCharacterState MarkAsPlayed(this CharactersAvailableState state, CharacterId character) =>
		(state with {PlayedCharacters = state.PlayedCharacters.Add(character)}).CharactersAvailableForSelection() switch
		{
			
			[] => new NoCharactersAvailableState(state.Data),
			_ => state with { PlayedCharacters = state.PlayedCharacters.Add(character) }
		};
		
}