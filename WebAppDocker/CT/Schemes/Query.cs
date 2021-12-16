using System;
using CT.Models;

namespace CT.Schemes;

public abstract class Query
{
    public Phone GetPhone() => new Phone
    {
        Model = "IPhone",
        Manufacturer = new Items
        {
            Manufacturer = "USA"
        },
        Id = 1
    };
}