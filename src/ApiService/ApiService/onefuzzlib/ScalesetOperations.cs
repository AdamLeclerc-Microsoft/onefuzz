﻿using ApiService.OneFuzzLib.Orm;

namespace Microsoft.OneFuzz.Service;

public interface IScalesetOperations : IOrm<Scaleset>
{
    IAsyncEnumerable<Scaleset> Search();
}

public class ScalesetOperations : Orm<Scaleset>, IScalesetOperations
{

    public ScalesetOperations(IStorage storage)
        : base(storage)
    {

    }

    public IAsyncEnumerable<Scaleset> Search()
    {
        return QueryAsync();
    }

}