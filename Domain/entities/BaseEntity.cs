using System;

namespace Domain.entities;

public class BaseEntity<Tid>
{
    public Tid Id { get; protected init; } = default!;
    protected BaseEntity() { }
}
