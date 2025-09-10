using System;
using System.Collections.Generic;

namespace Domain.entities;

public class Brand : BaseEntity<int>
{
    public string Name { get; set; } = default!;
    private Brand() { }
}
