using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Factories
{
    public interface IUpdateCollectionRequestFactory
    {
        UpdateCollectionRequestData GetInsertCollectionRequest(IIdoCommandBuilder builder);
        UpdateCollectionRequestData GetUpdateCollectionRequest(
            IIdoCommandBuilder builder, LoadCollectionResponseWrapper loadData);
    }
}