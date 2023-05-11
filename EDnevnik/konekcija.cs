using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eDnevnik
{
    class konekcija
    {
        public static SqlConnection connect()
        {
            SqlConnection veza = new SqlConnection("Data Source=DESKTOP-2N9D3N9\\SQLEXPRESS;Initial Catalog=ednevnik2022;Integrated Security=true");
            return veza;
        }
    }
}
