using System.Collections.Immutable;
using TrappedInside.Core.Characters;

namespace TrappedInside.Core;

public sealed record GameState(ImmutableArray<Character> Characters);


