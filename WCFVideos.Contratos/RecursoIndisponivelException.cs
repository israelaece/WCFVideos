using System;
using System.Runtime.Serialization;

namespace WCFVideos.Contratos
{
    public class RecursoIndisponivelException : Exception
    {
        public RecursoIndisponivelException()
            : base() { }

        public RecursoIndisponivelException(string message)
            : base(message) { }

        protected RecursoIndisponivelException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        public RecursoIndisponivelException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}