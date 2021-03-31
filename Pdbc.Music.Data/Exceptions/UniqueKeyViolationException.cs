using System;
using Pdbc.Music.Common.Exceptions;

namespace Pdbc.Music.Data.Exceptions
{
    public class UniqueKeyViolationException : MusicException
    {
        public UniqueKeyViolationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}