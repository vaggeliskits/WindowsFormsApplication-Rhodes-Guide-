using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        string connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        OleDbConnection conn;

        public static bool user = false;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Τουριστικός Οδηγός Ρόδου";

            conn = new OleDbConnection(connectionstring);

            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Play();
                button5.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button5.BackgroundImage = Properties.Resources.music_off;
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Form1.user = false;
            MessageBox.Show("Είσοδος ως Επισκέπτης.\nΚάποιες επιλογές δεν θα είναι διαθέσιμες για εσάς");

            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private int imageNumber = 1;
        private void loadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
             imgPicture.ImageLocation = string.Format(@"../../rodos_images/slidershow/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void σχετικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός Ρόδου\nΈκδοση: 1.0\nΑνάπτυξη:\nΚιτσούλης Ευάγγελος\nΠοσνακίδης Ηρακλής");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός Ρόδου\nΈκδοση: 1.0\nΑνάπτυξη:\nΚιτσούλης Ευάγγελος\nΠοσνακίδης Ηρακλής");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void date_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label4.Text = dateTime.ToString("dd/MM/yyyy\nHH:mm:ss");
        }

        //music control
        private void button5_Click(object sender, EventArgs e)
        {
            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button5.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button5.BackgroundImage = Properties.Resources.music_on;
            }
        }

        public static string textboxvalue;
        private void button1_Click(object sender, EventArgs e)
        {
            textboxvalue = textBox1.Text;

            int count = 0;


            chek_textbox chek = new chek_textbox();
            count = chek.chek_user(this.textBox1.Text, this.textBox2.Text);

            if (count == 1)
            {
                user = true;
                MessageBox.Show("Έγκυρα στοιχεία. Καλώς ήρθατε, "+ textBox1.Text.ToString()+".");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Μη έγκυρα στοιχεία. Παρακαλώ προσπαθήστε ξανά.");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            register reg = new register();
            reg.ShowDialog();
        }
    }
}
