using System;
using Pdbc.Music.Common.Exceptions;


namespace Pdbc.Music.Data.Exceptions
{
    public class DependentObjectStillUsedException : MusicException
    {
        public DependentObjectStillUsedException(Exception exception) : base("DependentObjectStillUsed", exception)
        {

        }
    }
}
