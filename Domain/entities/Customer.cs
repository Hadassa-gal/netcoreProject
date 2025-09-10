using System;
using Domain.valueObjects;

namespace Domain.entities;

public class Customer : BaseEntity<Guid>
{
    public string? FirstName { get; set; } = default!;
    public string? LastName { get; set; } = default!;
    public Email? Email { get; set; }
    private Customer() { }
}