using System;

namespace DB.Persistence.Exceptions
{
    public class AppException : Exception
    {
        public AppException(string message) : base(message) { }
    }
}