namespace TrappedInside.Core.Items;

public abstract record Item;
public sealed record CarryableItem(CarryableItemIdentifier Identifier);
public sealed record Key(KeyIdentifier Identifier) : Item;
