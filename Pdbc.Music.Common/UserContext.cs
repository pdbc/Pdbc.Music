using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
