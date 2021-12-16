﻿using HotChocolate.Types;

namespace HT.Schemes;

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor
            .Field(f => f.GetDevice())
            .Type<DeviceType>();
    }
}