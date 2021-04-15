using System;

namespace Pdbc.Music.Common
{
    public static class UserContext
    {
        public static String GetUsername()
        {
            // TODO - get from claims principal/httpcontext/....
            return "Patrick";
        }
    }
}
