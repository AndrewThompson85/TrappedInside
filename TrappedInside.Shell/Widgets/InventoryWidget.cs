using Spectre.Console;
using TrappedInside.Core;
using TrappedInside.Core.Items;
using TrappedInside.Shell.ShellFunctions;

namespace TrappedInside.Shell.Widgets;

public static class InventoryWidget
{
	public static void DrawInventoryWidget(Inventory inventory)
	{
		if (inventory.IsEmpty())
		{
			DrawCarryingNothing();
			return;
		}
		BasicShellFunctions.BlankLines(1);
		BasicShellFunctions.DrawRule("You are carrying..", ViewInvariants.InfoRowColor);
		BasicShellFunctions.BlankLines(1);

		DrawCarryablesTable(inventory);
		DrawKeysTable(inventory);
	}

	private static void DrawCarryingNothing()
	{
		BasicShellFunctions.BlankLines(1);
		BasicShellFunctions.DrawRule("You are not carrying any items.", ViewInvariants.InfoRowColor);
		BasicShellFunctions.BlankLines(1);
	}

	private static void DrawKeysTable(Inventory inventory)
	{
		var keysTable = new Table
		{
			Title = new TableTitle("Keys"),
		};
		
		keysTable.AddColumn("Name");
		keysTable.AddColumn("Description");

		foreach (var key in inventory.Keys)
		{
			keysTable.AddRow(key.DisplayName(), key.Description());
		}

	
		AnsiConsole.Write(keysTable.Expand());
		BasicShellFunctions.BlankLines(1);
	}

	private static void DrawCarryablesTable(Inventory inventory)
	{
		var itemsTable = new Table
		{
			Title = new TableTitle("Items"),
		};
		
		itemsTable.AddColumn("Name");
		itemsTable.AddColumn("Description");

		foreach (var item in inventory.Carryables)
		{
			itemsTable.AddRow(item.DisplayName(), item.Description());
		}
		
		AnsiConsole.Write(itemsTable.Expand());
		
		BasicShellFunctions.BlankLines(1);
	}
}