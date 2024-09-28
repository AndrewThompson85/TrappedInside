using TrappedInside.Core.Characters;
using TrappedInside.Core.Items;
using TrappedInside.Core.Primitives;
using static TrappedInside.Core.Characters.CharacterId;

namespace TrappedInside.Core;

public static class Invariants
{
	public const uint ActionsPerTurn = 3;
	
	public static Text Name(this CharacterId character) => character switch
	{
		Alex => "Alex",
		Bill => "Bill",
		Olivia => "Olivia",
		Sandra => "Sandra"
	};

	public static Text DisplayName(this Carryable carryable) => carryable switch
	{
		Carryable.Pickaxe => "Pickaxe",
		Carryable.Shotgun => "Shotgun"
	};

	public static Text Description(this Carryable carryable) => carryable switch
	{
		Carryable.Pickaxe => "A large pickaxe with a wooden handle.",
		Carryable.Shotgun => "A double barrelled shotgun"
	};
	
	public static Text DisplayName(this Key key) => key switch
	{
		Key.MasterBedroomKey => "Master Bedroom"
		
	};

	public static Text Description(this Key key) => key switch
	{
		Key.MasterBedroomKey => "This is the key to the Master Bedroom",
	};

}