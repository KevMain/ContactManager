using System;

namespace CompatibleSoftware.Infrastructure.Exceptions
{
    public interface IExceptionPolicy
    {
        bool HandleException(object sender, Exception exception);
    }
}
