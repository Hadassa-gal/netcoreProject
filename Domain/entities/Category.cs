using System;

namespace Domain.entities;

public class Category : BaseEntity<int>
{
    public string? Name { get; set; } = default!;
    private Category() { }
}
