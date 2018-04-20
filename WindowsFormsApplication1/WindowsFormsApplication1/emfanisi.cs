using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class emfanisi : Form
    {
        string connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        OleDbConnection conn;
        public emfanisi()
        {
            InitializeComponent();
            conn = new OleDbConnection(connectionstring);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sxolia.comments == 1)
            {
                this.Hide();
                aksiotheata aks = new aksiotheata();
                aks.ShowDialog();
            }
            else if (sxolia.comments == 2)
            {
                this.Hide();
                paralies par = new paralies();
                par.ShowDialog();
            }
            else if (sxolia.comments == 3)
            {
                this.Hide();
                estiatoria est = new estiatoria();
                est.ShowDialog();
            }
            else
            {
                this.Hide();
                ekdiloseis ekd = new ekdiloseis();
                ekd.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sxolia.comments == 1)
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                String myquery = "Select * from  Database1.users";
                OleDbCommand cmd = new OleDbCommand(myquery, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //richTextBox1(rdr.GetValue(1).ToString())
                    label2.Text = "## " + rdr.GetValue(3).ToString() + "\n\n" + label2.Text;
                    //MessageBox.Show(rdr.GetValue(2).ToString());
                }
                conn.Close();
            }
            else if(sxolia.comments == 2)
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                String myquery = "Select * from  Database1.users";
                OleDbCommand cmd = new OleDbCommand(myquery, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    label2.Text = "## " + rdr.GetValue(4).ToString() + "\n\n" + label2.Text;
                }
                conn.Close();
            }
            else if(sxolia.comments == 3)
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                String myquery = "Select * from  Database1.users";
                OleDbCommand cmd = new OleDbCommand(myquery, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    label2.Text = "## " + rdr.GetValue(5).ToString() + "\n\n" + label2.Text;
                }
                conn.Close();
            }
            else
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                String myquery = "Select * from  Database1.users";
                OleDbCommand cmd = new OleDbCommand(myquery, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    label2.Text = "## " + rdr.GetValue(6).ToString() + "\n\n" + label2.Text;
                }
                conn.Close();
            }
            
        }
    }
}
