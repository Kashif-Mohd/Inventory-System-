using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Project
{
    class LgnStatus
    {
        public static string UserName = "";
        public static string Logfrom = "";
        public static Form main;

        public static Form frmlogin;



        public static string Store_User
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }

        public static Form Log_Form
        {
            get
            {
                return frmlogin;
            }
            set
            {
                frmlogin = value;
            }
        }

        public static Form Login
        {
            get
            {
                return main;
            }
            set
            {
                main = value;
            }
        }


    }
}
