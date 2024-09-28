using System.Collections.Immutable;
using TrappedInside.Core.Characters;
using TrappedInside.Core.Data;

namespace TrappedInside.Core.States.SelectingCharacter;

public abstract record SelectingCharacterState(GameData Data) : State(Data);
public sealed record CharactersAvailableState(GameData Data, ImmutableHashSet<CharacterId> PlayedCharacters) : SelectingCharacterState(Data);
public sealed record NoCharactersAvailableState(GameData Data) : SelectingCharacterState(Data);