using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class chek_textbox
    {
        string connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        OleDbConnection conn;
        public chek_textbox()
        {
            conn = new OleDbConnection(connectionstring);
        }

        public int chek_user(String username, String password)
        {
            conn.Open();


            OleDbCommand SelectCommand = new OleDbCommand("SELECT * FROM Database1.users WHERE Username='" + username + "' AND Password='" + password + "';", conn);

            OleDbDataReader myReader;

            myReader = SelectCommand.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {
                count = count + 1;
            }
            conn.Close();

            return count;
        }
    }


}
