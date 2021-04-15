using Pdbc.Music.Common.Exceptions;
using System;


namespace Pdbc.Music.Data.Exceptions
{
    public class DependentObjectStillUsedException : MusicException
    {
        public DependentObjectStillUsedException(Exception exception) : base("DependentObjectStillUsed", exception)
        {

        }
    }
}
