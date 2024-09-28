using TrappedInside.Core.Primitives;

namespace TrappedInside.Core.Information;

public abstract record Info;

public sealed record BasicMessage(Text Message) : Info;