using System.Collections.Immutable;

namespace TrappedInside.Core.Items;

public sealed record Inventory(ImmutableHashSet<Carryable> Carryables, ImmutableHashSet<Key> Keys)
{
	public static readonly Inventory Empty = new([], []);
};