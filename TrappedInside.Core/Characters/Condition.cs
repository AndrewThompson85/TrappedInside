namespace TrappedInside.Core.Characters;

public abstract record Condition;

public sealed record Healthy : Condition;
public sealed record Infected(uint TurnsRemaining) : Condition;
public sealed record Injured(uint TurnsRemaining) : Condition;