using System;
using HT.Models;

namespace HT.Schemes;

public class Query
{
    public Device GetDevice() => new()
    {
        Name = "Phone",
        Category = new Category
        {
            CategoryName = "Phones"
        },
        Id = Guid.NewGuid()
    };
}