using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Constants
{
    public class Constants
    {
        #region Keys Value
        public const string GET_ALL_USER_URL = "https://api.github.com/search/[query]";
        public const string GET_USER_URL = "https://api.github.com/users/[login]";
        public const string GET_USER_REPOS_URL = "https://api.github.com/users/[login]/repos";
        #endregion
    }
}