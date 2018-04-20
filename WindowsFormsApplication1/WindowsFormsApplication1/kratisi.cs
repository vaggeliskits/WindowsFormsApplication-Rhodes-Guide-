using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class kratisi : Form
    {
        public bool from;
        public kratisi()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now; //disabling past dates on calendar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                // At least 1 textbox is empty.
                MessageBox.Show("Παρακαλώ καταχωρήστε τα στοιχεία σας.");
            }
            else
            {
                // All the textboxes are filled in.
                int i;
                if (!int.TryParse(textBox1.Text, out i))
                {
                    if (!int.TryParse(textBox2.Text, out i))
                    {
                        if ((!int.TryParse(textBox3.Text, out i)) || (!int.TryParse(textBox4.Text, out i)))
                        {
                            MessageBox.Show("Παρακαλώ καταχωρήστε τα στοιχεία σας.");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Η κράτηση σας πραγματοποιήθηκε με επιτυχία.\nΕυχαριστούμε πολυ για την επιλογή σας.\n\nΣτοιχεία Κράτησης\nΌνομα: "+textBox1.Text+"\nΕπώνυμο: "+textBox2.Text+"\nΤηλέφωνο: "+textBox3.Text.ToString()+"\nΆτομα: "+textBox4.Text.ToString()+"\nΗμερομηνία: "+dateTimePicker1.Value.ToString("dd-MM-yyyy") + "\nΏρα: "+comboBox1.Text.ToString());
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            if (from == true)
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
                    }
                    else
                    {
                        MessageBox.Show("Παρακαλώ καταχωρήστε τα στοιχεία σας.");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                    }    
                }
                else
                {
                    MessageBox.Show("Παρακαλώ καταχωρήστε τα στοιχεία σας.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(from == true)
            {
                MessageBox.Show("Η κράτησή σας δεν πραγματοποιήθηκε.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                this.Hide();
                estiatoria est = new estiatoria();
                est.ShowDialog();
            }
            else
            {
                MessageBox.Show("Η κράτησή σας δεν πραγματοποιήθηκε.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                this.Hide();
                ekdiloseis ekd = new ekdiloseis();
                ekd.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
