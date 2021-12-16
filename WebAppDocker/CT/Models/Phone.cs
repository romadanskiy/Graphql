using System;
using HotChocolate;
using HotChocolate.Types;

namespace CT.Models;

public class Phone
{
    [GraphQLType(typeof(IdType))]
    public Guid Id { get; set; }
    public string Model { get; set; } = null!;

    public Items Manufacturer { get; set; } = null!;
}