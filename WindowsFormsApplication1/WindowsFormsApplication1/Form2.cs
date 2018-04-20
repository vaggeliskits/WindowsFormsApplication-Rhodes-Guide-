using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Αρχικό Μενού";

            if (music.medplay == true)
            {
                button4.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button4.BackgroundImage = Properties.Resources.music_off;
            }

            //history control
            if (history.aksiotheata == true)
            {
                button5.BackColor = Color.LightGreen;
            }
            if(history.paralies == true)
            {
                button6.BackColor = Color.LightGreen;
            }
            if (history.estiatoria == true)
            {
                button7.BackColor = Color.LightGreen;
            }
            if (history.ekdiloseis == true)
            {
                button8.BackColor = Color.LightGreen;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void σχετικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός Ρόδου\nΈκδοση: 1.0\nΑνάπτυξη:\nΚιτσούλης Ευάγγελος\nΠοσνακίδης Ηρακλής");
        }

        //music control
        private void button4_Click(object sender, EventArgs e)
        {
            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button4.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button4.BackgroundImage = Properties.Resources.music_on;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            history.aksiotheata = true;
            sxolia.comments = 1;
            this.Hide();
            aksiotheata aks = new aksiotheata();
            aks.ShowDialog();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            history.paralies = true;
            sxolia.comments = 2;
            this.Hide();
            paralies par = new paralies();
            par.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            history.estiatoria = true;
            sxolia.comments = 3;
            this.Hide();
            estiatoria est = new estiatoria();
            est.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            history.ekdiloseis = true;
            sxolia.comments = 4;
            this.Hide();
            ekdiloseis ekd = new ekdiloseis();
            ekd.ShowDialog();
        }

        private void εμφάνισηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {

            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
        }

        //clearing history
        private void button9_Click(object sender, EventArgs e)
        {
            button5.BackColor = SystemColors.Control;
            button5.UseVisualStyleBackColor = true;
            history.aksiotheata = false;
            button6.BackColor = SystemColors.Control;
            button6.UseVisualStyleBackColor = true;
            history.paralies = false;
            button7.BackColor = SystemColors.Control;
            button7.UseVisualStyleBackColor = true;
            history.estiatoria = false;
            button8.BackColor = SystemColors.Control;
            button8.UseVisualStyleBackColor = true;
            history.ekdiloseis = false;
        }
    }
}
