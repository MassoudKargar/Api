using System;

namespace Api.Domain.Exceptions
{
    public class ExceptionBase : Exception
    {
        public ExceptionBase(string message) : base(message)
        {
        }
    }
}
