using System.Collections.Immutable;
using TrappedInside.Core.Characters;

namespace TrappedInside.Core.States.SelectingCharacter;

public sealed record SelectingCharacterState(GameData Data, ImmutableHashSet<CharacterId> PlayedCharacters) : State(Data);

public static class SelectingCharacterStateFunctions
{
	public static ImmutableArray<CharacterId> CharactersAvailableForSelection(this SelectingCharacterState state) => [..
			from character in CharacterFunctions.AllCharacters
			where state.Data.AliveCharacters().Ids().Contains(character)
			where state.PlayedCharacters.Contains(character) == false
			select character];

	public static SelectingCharacterState MarkAsPlayed(this SelectingCharacterState state, CharacterId character) =>
		state with { PlayedCharacters = state.PlayedCharacters.Add(character) };
}

