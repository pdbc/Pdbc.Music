using System;

namespace Pdbc.Music.Common.Exceptions
{
    public class MusicException : ApplicationException
    {
        protected MusicException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
