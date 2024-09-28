using System.Collections.Immutable;
using TrappedInside.Core.Items;

namespace TrappedInside.Core.Characters;

public sealed record Inventory(ImmutableArray<CarryableItem> Items)
{
	public static Inventory Empty = new([]);
};