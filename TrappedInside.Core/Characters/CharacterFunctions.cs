using System.Collections.Immutable;
using TrappedInside.Core.Data;
using TrappedInside.Core.Primitives;

namespace TrappedInside.Core.Characters;

public static class CharacterFunctions
{
	public static ImmutableArray<AliveCharacter> AliveCharacters(this GameData gameData) =>
		[..gameData.Characters.OfType<AliveCharacter>()];

	public static ImmutableArray<CharacterId> Ids(this ImmutableArray<AliveCharacter> characters) =>
		[..characters.Select(c => c.Id)];

	public static readonly ImmutableArray<CharacterId> AllCharacters = [..Enum.GetValues<CharacterId>()];
	
	public static Text Name(this Character character) => character.Id.Name();
}