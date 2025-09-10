using System;
using Domain.ValueObjects;

namespace Domain.entities;

public class Product : BaseEntity<int>
{
    public string? Name { get; set; } = default!;
    public string? Description { get; set; }
    public Money Price { get; set; }
    public bool IsActive { get; set; }
    private Product() { } // EF
}