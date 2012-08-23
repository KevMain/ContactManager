using System;
using System.Runtime.Serialization;

namespace CompatibleSoftware.Infrastructure
{
    [Serializable]
    public class CustomFatalException : Exception
    {
        private readonly String _localizedMessage;

        public CustomFatalException(String message)
            : base(message)
        {
            _localizedMessage = message;
        }

        public CustomFatalException(String message, Exception innerException)
            : base(message, innerException)
        {
            _localizedMessage = message;
        }

        protected CustomFatalException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public String LocalizedMessage { get { return _localizedMessage; } }
    }
}
