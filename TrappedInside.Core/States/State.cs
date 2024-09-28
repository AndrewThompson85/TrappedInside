namespace TrappedInside.Core.States;

public abstract record State(GameData Data);

public sealed record NewTurnState(GameData Data) : State(Data);