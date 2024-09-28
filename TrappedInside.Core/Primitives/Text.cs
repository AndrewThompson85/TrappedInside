namespace TrappedInside.Core.Primitives;

public sealed record Text
{
	public Text(string Value)
	{
		if (string.IsNullOrWhiteSpace(Value))
		{
			throw new Exception("Text cannot be null or blank.");
		}
		this.Value = Value;
	}

	public string Value { get; init; }

	public void Deconstruct(out string value)
	{
		value = this.Value;
	}

	public static implicit operator Text(string value) => new Text(value);
	
}