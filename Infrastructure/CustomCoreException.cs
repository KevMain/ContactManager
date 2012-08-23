using System;
using System.Runtime.Serialization;

namespace CompatibleSoftware.Infrastructure
{
    [Serializable]
    public class CustomCoreException : Exception
    {
        private readonly String _localizedMessage;

        public CustomCoreException(String message)
            : base(message)
        {
            _localizedMessage = message;
        }

        public CustomCoreException(String message, Exception innerException)
            : base(message, innerException)
        {
            _localizedMessage = message;
        }

        protected CustomCoreException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public String LocalizedMessage { get { return _localizedMessage; } }
    }
}
