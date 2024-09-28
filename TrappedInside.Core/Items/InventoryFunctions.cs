namespace TrappedInside.Core.Items;

public static class InventoryFunctions
{
	public static Inventory AddCarryable(this Inventory inventory, Carryable carryable) =>
		inventory with { Carryables = inventory.Carryables.Add(carryable) };

	public static Inventory AddKey(this Inventory inventory, Key key) =>
		inventory with { Keys = inventory.Keys.Add(key) };
}