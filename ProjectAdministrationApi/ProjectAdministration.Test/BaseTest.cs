using Moq;
using ProjectAdministration.Core.Interfaces;
using ProjectAdministration.Core.Models;
using Xunit;

namespace ProjectAdministration.Test
{
    [Collection("Mapper Collection")]
    public abstract class BaseTest
    {
        internal readonly Mock<IAsyncRepository<Project>> ProjectRepositoryMock = new Mock<IAsyncRepository<Project>>();
        internal readonly TestDataProvider TestDataProvider;
        internal readonly MapperFixture Fixture;

        protected BaseTest(MapperFixture fixture)
        {
            Fixture = fixture;
            TestDataProvider = new TestDataProvider();
        }
    }
}