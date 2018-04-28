using System;
using System.Threading.Tasks;

namespace ProjectAdministration.Infrastructure.Logger
{
    public class ApplicationInsightsLogger : IProjectAdministrationLogger
    {
        public Task LogException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}