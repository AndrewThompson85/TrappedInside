namespace TrappedInside.Core.Items;

public static class InventoryFunctions
{
	public static Inventory AddCarryable(this Inventory inventory, Carryable carryable) =>
		inventory with { Carryables = inventory.Carryables.Add(carryable) };

	public static Inventory AddKey(this Inventory inventory, Key key) =>
		inventory with { Keys = inventory.Keys.Add(key) };

	public static bool IsEmpty(this Inventory inventory) => !(inventory.Carryables.Any() || inventory.Keys.Any());
	public static bool HasKeys(this Inventory inventory) => inventory.Keys.Any();
	public static bool HasCarryables(this Inventory inventory) => inventory.Carryables.Any();
}