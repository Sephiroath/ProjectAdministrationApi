using System;
using System.Threading.Tasks;

namespace ProjectAdministration.Infrastructure.Logger
{
    public interface IProjectAdministrationLogger
    {
        Task LogException(Exception exception);
    }
}