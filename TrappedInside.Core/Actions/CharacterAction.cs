using System.Collections.Immutable;
using TrappedInside.Core.Actions.Queries;
using TrappedInside.Core.Information;
using TrappedInside.Core.States.CharacterActions;

namespace TrappedInside.Core.Actions;

public sealed record CharacterAction(ActionCategory Category, CharacterActionFunction Function, string Description, ImmutableArray<Info> Information);

public static class CharacterActionExtensions
{
	public static CharacterAction UsesAnAction(this CharacterAction action) =>
		action with { Function = UsesAnAction(action.Function) };

	public static CharacterActionFunction UsesAnAction(this CharacterActionFunction function) =>
		state => function(state).ConsumeAnAction();

	public static ImmutableArray<CharacterAction> GetAllAvailableActions(this CharacterActionState state) =>
	[
		..state.GetAvailableMoves(),
		..state.GetAvailableQueries()
	];
}