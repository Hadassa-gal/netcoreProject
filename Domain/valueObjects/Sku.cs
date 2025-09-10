namespace Domain.valueObjects;

public record class Sku
{
    public string Value { get; }

    public Sku(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("SKU required.", nameof(value));
        Value = value.Trim().ToUpperInvariant();
    }

    public override string ToString() => Value;
}
