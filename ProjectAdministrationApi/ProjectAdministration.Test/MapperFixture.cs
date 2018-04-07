using System;
using AutoMapper;
using ProjectAdministration.Core.Mappers;
using Xunit;

namespace ProjectAdministration.Test
{
    public class MapperFixture : IDisposable
    {
        public MapperFixture()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ProjectMapper>();
                cfg.AddProfile<PhaseMapper>();
                cfg.AddProfile<PriorityMapper>();
                cfg.AddProfile<StatusMapper>();
            });
        }
        public void Dispose()
        {
            Mapper.Reset();
        }
    }
    [CollectionDefinition("Mapper Collection")]
    public class DatabaseCollection : ICollectionFixture<MapperFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}