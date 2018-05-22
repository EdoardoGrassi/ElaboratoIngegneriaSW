using System.Collections.Generic;

namespace ProgettoIngegneriaSW.Authentication
{
    public class AuthenticationDatabase
    {
        private readonly string path;
        private readonly Dictionary<string, int> database;

        /// <summary>
        /// Creates a new database filled with data loaded from <paramref name="filePath"/>
        /// </summary>
        /// <param name="filePath">Path to the saved file</param>
        public AuthenticationDatabase(string filePath)
        {
            this.path = filePath;
        }

        /// <summary>
        /// Tries to authenticate an user from his username and password
        /// </summary>
        /// <param name="username">Name of the user</param>
        /// <param name="password">Password of the user</param>
        /// <returns>Returns an authentication token</returns>
        public AuthenticationToken AuthenticateUser(string username, string password)
        {
            if (this.database.TryGetValue(username, out int hash))
            {

            }
            return AuthenticationToken.NonAuthenticated;
        }
    }
}
