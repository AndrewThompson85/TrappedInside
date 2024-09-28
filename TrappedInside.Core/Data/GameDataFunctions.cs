using TrappedInside.Core.Characters;
using TrappedInside.Core.Environment;

namespace TrappedInside.Core.Data;

public static class GameDataFunctions
{
	public static GameData NextTurn(this GameData data) => data with { Turn = data.Turn + 1 };

	public static GameData MoveCharacterTo(this GameData data, CharacterId who, RoomIdentifier destination)
	{
		var currentCharacters = data.Characters;
		var character = currentCharacters.Single(c => c.Id == who);

		return data with
		{
			Characters = currentCharacters.Replace(character, character with { Location = destination })
		};
	}
}