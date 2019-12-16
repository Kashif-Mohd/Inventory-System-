using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Project
{
    class MyVars
    {
        public static string qty = "";
        public static string icno = "";
        
        public static string date = "";
        public static Form main;


        public static string Store_ICNO
        {
            get
            {
                return icno;
            }

            set
            {
                icno = value;
            }
        }


       


        public static string Store_Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public static string Store_Qty
        {
            get
            {
                return qty;
            }

            set
            {
                qty = value;
            }
        }

        public static Form visit
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



        /* internal static DateTime Store_Date(Func<string> ToString)
         {
             throw new NotImplementedException();
         }*/
    }
}
