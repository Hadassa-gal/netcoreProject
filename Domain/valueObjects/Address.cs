namespace Domain.valueObjects;

public sealed record class Address(string Line1, string City, string State, string Country, string ZipCode);
