using System;
using System.Runtime.Serialization;

namespace CompatibleSoftware.Infrastructure.Security
{
    [Serializable]
    public class CustomSecurityException : CustomCoreException
    {
        public CustomSecurityException(String message) : base(message) { }
        public CustomSecurityException(String message, Exception innerException) : base(message, innerException) { }
        protected CustomSecurityException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
