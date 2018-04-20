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
    public partial class sxolia : Form
    {

        string connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        OleDbConnection conn;
        public static int comments;
        public sxolia()
        {
            InitializeComponent();
            conn = new OleDbConnection(connectionstring);
        }

        private void button2_Click(object sender, EventArgs e)
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(sxolia.comments == 1)
            {
                if(aksiotheata.aks == 1)
                {
                    richTextBox1.AppendText(" <--Παλια Πόλη");
                }
                else if(aksiotheata.aks == 2)
                {
                    richTextBox1.AppendText(" <--Ενυδρείο ");
                }
                else if(aksiotheata.aks == 3)
                {
                    richTextBox1.AppendText(" <--Ακρόπολη ");
                }
                else if(aksiotheata.aks == 4)
                {
                    richTextBox1.AppendText(" <--Κοιλάδα των Πεταλούδων ");
                }
                string text = Form1.textboxvalue;
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "insert into Database1.users ([aksiotheata]) values ('" + richTextBox1.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Το σχόλιο καταχωρήθηκε επιτυχώς.");
                richTextBox1.Clear();
                this.Hide();
                aksiotheata aks = new aksiotheata();
                aks.ShowDialog();
                conn.Close();
            }
            else if (sxolia.comments == 2)
            {
                if (paralies.par == 1)
                {
                    richTextBox1.AppendText(" <--Καλλιθέα");
                }
                else if (paralies.par == 2)
                {
                    richTextBox1.AppendText(" <--Φαληράκι ");
                }
                else if (paralies.par == 3)
                {
                    richTextBox1.AppendText(" <--Άντονυ Κουίν ");
                }
                else if (paralies.par == 4)
                {
                    richTextBox1.AppendText(" <--Τσαμπίκα ");
                }
                string text = Form1.textboxvalue;
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "insert into Database1.users ([paralies]) values ('" + richTextBox1.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Το σχόλιο καταχωρήθηκε επιτυχώς.");
                richTextBox1.Clear();
                this.Hide();
                paralies par = new paralies();
                par.ShowDialog();
                conn.Close();
            }
            else if(sxolia.comments == 3)
            {
                if (estiatoria.est == 1)
                {
                    richTextBox1.AppendText(" <--Σαρρής Ταβέρνα");
                }
                else if (estiatoria.est == 2)
                {
                    richTextBox1.AppendText(" <--Canton Chinese Restaurant ");
                }
                else if (estiatoria.est == 3)
                {
                    richTextBox1.AppendText(" <--Romeo Restaurant ");
                }
                string text = Form1.textboxvalue;
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "insert into Database1.users ([estiatoria]) values ('" + richTextBox1.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Το σχόλιο καταχωρήθηκε επιτυχώς.");
                richTextBox1.Clear();
                this.Hide();
                estiatoria est = new estiatoria();
                est.ShowDialog();
                conn.Close();
            }
            else
            {
                if (ekdiloseis.ekd == 1)
                {
                    richTextBox1.AppendText(" <--Bραδιά Jazz");
                }
                else if (ekdiloseis.ekd == 2)
                {
                    richTextBox1.AppendText(" <--Έκθεση Ζωγραφικής ");
                }
                string text = Form1.textboxvalue;
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "insert into Database1.users ([ekdiloseis]) values ('" + richTextBox1.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Το σχόλιο καταχωρήθηκε επιτυχώς.");
                richTextBox1.Clear();
                this.Hide();
                ekdiloseis ekd = new ekdiloseis();
                ekd.ShowDialog();
                conn.Close();
            }
            

        }
    }
}
