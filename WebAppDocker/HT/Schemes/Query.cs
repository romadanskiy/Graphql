using System;
using HT.Models;

namespace HT.Schemes;

public abstract class Query
{
    public Device GetDevice() => new Device()
    {
        Name = "Phone",
        Category = new Categories
        {
            Category = "Phones"
        },
        Id = Guid.NewGuid()
    };
}