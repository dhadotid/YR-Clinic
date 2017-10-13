using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YR_Clinic.config
{
    class DBConnection
    {
        private string db = "Data Source=DESKTOP-MEO5I55\\DHADOTID; Initial Catalog=YR; User ID=sa; Password=qwerty";
        //private string db = "Data Source=DESKTOP-OVBH2KD\\NISRINA; Initial Catalog=YR; User ID=sa; Password=1sendaljepit";

        public SqlConnection con;
        private string info;

        public DBConnection()
        {
            con = new SqlConnection(db);
        }
        public string openconnection()
        {
            try
            {
                con.Open();
                info = "OK";
            }
            catch (Exception ex)
            {
                con.Close();
                info = ex.Message;
            }
            return info;
        }
        public string closeconnection()
        {
            try
            {
                con.Close();
                info = "OK";
            }
            catch (Exception ex)
            {
                con.Close();
                info = ex.Message;
            }
            return info;
        }
    }
}
