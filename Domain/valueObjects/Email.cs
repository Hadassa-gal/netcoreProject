namespace Domain.valueObjects;

public record class Email
{
    public string Value { get; }
    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !value.Contains('@'))
            throw new ArgumentException("Invalid email.", nameof(value));
        Value = value.Trim().ToLowerInvariant();
    }
    public override string ToString() => Value;
}
