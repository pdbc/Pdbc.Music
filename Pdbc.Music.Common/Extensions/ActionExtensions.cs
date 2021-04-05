using System;

namespace Pdbc.Music.Common.Extensions
{
    public static class ActionExtensions
    {
        public static void IgnoreException(this Action action)
        {
            try
            {
                action();
            }
            catch (Exception) { }
        }
    }
}