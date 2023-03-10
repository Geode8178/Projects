using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace InventoryControlSystem.General_Classes
{
    public class IcsConnect
    {
        
        public static string IcsConnetString()
        {
            return ConfigurationManager.ConnectionStrings["ICS"].ConnectionString; // Configuration Manager calls connection string established in App.config file.
        }

    }
}
