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
    public partial class register : Form
    {
        string connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        OleDbConnection conn;
        public register()
        {
            InitializeComponent();
            this.Text = "Εγγραφή Χρήστη";
            conn = new OleDbConnection(connectionstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Database1.users ([Username], [Password]) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "');";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Η εγγραφή ήταν επιτυχής. Καλώς ήρθατε, "+textBox1.Text.ToString()+".");
            Form1.user = true;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Database1.users ([Username], [Password]) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "');";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Η εγγραφή ήταν επιτυχής.");
            Form1.user = true;
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
