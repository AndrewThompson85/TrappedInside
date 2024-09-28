using System.Collections.Immutable;
using TrappedInside.Core.Characters;

namespace TrappedInside.Core.States;

public abstract record State(GameData Data);

public sealed record NewTurnState(GameData Data) : State(Data);
public sealed record SelectingCharacterState(GameData Data, ImmutableArray<CharacterId> AvailableChoices) : State(Data);