using System;
using HotChocolate;
using HotChocolate.Types;

namespace HT.Models;

public class Device
{
    [GraphQLType(typeof(IdType))]
    public int Id { get; set; } 
    public string Name { get; set; } = null!;
    public Category Category { get; set; } = null!;
}