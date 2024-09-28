using System.Collections.Immutable;

namespace TrappedInside.Core.Characters;

public static class CharacterFunctions
{
	public static ImmutableArray<AliveCharacter> AliveCharacters(this GameState gameState) =>
		[..gameState.Characters.OfType<AliveCharacter>()];
}