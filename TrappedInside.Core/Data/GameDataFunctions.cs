namespace TrappedInside.Core.Data;

public static class GameDataFunctions
{
	public static GameData NextTurn(this GameData data) => data with { Turn = data.Turn + 1 };
}