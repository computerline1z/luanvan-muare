using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DTO;
using BUS;
using System.Collections;

namespace MuaRe.Congty
{
    public class CongTyWebService : System.Web.Services.WebService
    {

        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static string[] GetCompletionList(string prefixText, int count, string contextKey)
        {
            // Create array of movies  
            string[] movies = { "Star Wars", "Star Trek", "Superman", "Memento", "Shrek", "Shrek II" };

            // Return matching movies  
            return (from m in movies where m.StartsWith(prefixText, StringComparison.CurrentCultureIgnoreCase) select m).Take(count).ToArray();
        }       
    }
}
