using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoIngegneriaSW.Authentication
{
    public class AuthenticationToken
    {
        public AuthenticationToken(AuthorizationLevel level)
        {
            // TODO: review, bad performance (check is done via reflection)
            Debug.Assert(Enum.IsDefined(typeof(AuthorizationLevel), level), "Enum value not supported");

            AuthenticationLevel = level;
        }

        public static AuthenticationToken NonAuthenticated
        {
            get
            {
                return new AuthenticationToken(AuthorizationLevel.NonAuthenticated);
            }
        }

        public AuthorizationLevel AuthenticationLevel { get; }
    }
}
