using System.Collections.Immutable;
using TrappedInside.Core.Characters;
using TrappedInside.Core.Data;

namespace TrappedInside.Core.States.SelectingCharacter;

public sealed record SelectingCharacterState(GameData Data, ImmutableHashSet<CharacterId> PlayedCharacters) : State(Data);