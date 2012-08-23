using System;
using System.Runtime.Serialization;

namespace CompatibleSoftware.Infrastructure
{
    [Serializable]
    public class CustomException : ApplicationException
    {
        private readonly String _localizedMessage;

        public CustomException(String message)
            : base(message)
        {
            _localizedMessage = message;
        }

        public CustomException(String message, Exception innerException)
            : base(message, innerException)
        {
            _localizedMessage = message;
        }

        protected CustomException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public String LocalizedMessage { get { return _localizedMessage; } }
    }
}
