using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Inventory_Management_Project
{
    class DataBaseName
    {
        public static string Data = ConfigurationManager.ConnectionStrings["Inventory_Management_Project.Properties.Settings.Inventory_System_AKUConnectionString"].ConnectionString;
        //public static string Data = "Data Source=Kashif-PC;Integrated Security=True;Initial Catalog=Inventory System AKU";
        //public static string Data = "Data Source=WAQAR-PC;Initial Catalog=INVENT;User ID=sa;Password=sa";
    }
}
