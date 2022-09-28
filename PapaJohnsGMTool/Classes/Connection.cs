using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaJohnsGMTool.Classes
{
    public class Connection
    {
        public static string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["PJGMT"].ConnectionString;
        }
    }
}
