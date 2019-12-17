using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ImportLegacy
{
    public static class Settings
    {
        private static readonly string accessConnectionDbTemplate = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq={{filename}};";
        private static readonly string accessConnectionUserTemplate = "Uid={{username}};Pwd={{password}};";

        public static string LegacyConnectionString(string filename)
        {
            //var values = new Dictionary<string, string>() { { nameof(filename), filename } };
            //return Regex.Replace(accessConnectionDbTemplate, "{{(?<field>[^}]+)}}", values["${field}"]);
            //return Regex.Replace(accessConnectionDbTemplate, "{{filename}}", filename);
            return @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" + filename + ";Uid=admin;Pwd=;";
        }

        public static string LegacyConnectionString(string filename, string username, string password)
        {
            var values = new Dictionary<string, string>() { { nameof(filename), filename }, { nameof(username), username }, { nameof(password), password } };
            return Regex.Replace(accessConnectionDbTemplate + accessConnectionUserTemplate, "{{(?<field>[^}]+)}}", values["${field}"]);
        }
    }
}
