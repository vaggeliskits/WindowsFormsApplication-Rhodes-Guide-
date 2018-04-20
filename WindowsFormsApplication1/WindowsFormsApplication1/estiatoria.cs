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
    public partial class estiatoria : Form
    {
        public static int est = 0;
        public estiatoria()
        {
            InitializeComponent();
            this.Text = "Εστιατόρια";

            if (music.medplay == true)
            {
                button5.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button5.BackgroundImage = Properties.Resources.music_off;
            }

            //history control
            if (history.greek_pli == true)
            {
                button1.BackColor = Color.LightGreen;
            }
            if(history.greek_sxo == true)
            {
                button8.BackColor = Color.LightGreen;
            }
            if(history.chinese_pli == true)
            {
                button2.BackColor = Color.LightGreen;
            }
            if(history.chinese_sxo == true)
            {
                button9.BackColor = Color.LightGreen;
            }
            if(history.italian_pli == true)
            {
                button3.BackColor = Color.LightGreen;
            }
            if(history.italian_sxo == true)
            {
                button10.BackColor = Color.LightGreen;
            }
        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fo = new Form1();
            fo.ShowDialog();
        }

        private void σχετικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός Ρόδου\nΈκδοση: 1.0\nΑνάπτυξη:\nΚιτσούλης Ευάγγελος\nΠοσνακίδης Ηρακλής");
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fo = new Form2();
            fo.ShowDialog();
        }

        //music control
        private void button5_Click(object sender, EventArgs e)
        {
            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button2.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button2.BackgroundImage = Properties.Resources.music_on;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            history.greek_pli = true;
            this.Hide();
            Greek gr = new Greek();
            gr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            history.chinese_pli = true;
            this.Hide();
            chinese ch = new chinese();
            ch.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            history.italian_pli = true;
            this.Hide();
            italian it = new italian();
            it.ShowDialog();
        }

        private void εμφάνισηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.user == true)
            {
                this.Hide();
                emfanisi emf = new emfanisi();
                emf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        //clearing history
        private void button11_Click(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button1.UseVisualStyleBackColor = true;
            history.greek_pli = false;
            button8.BackColor = SystemColors.Control;
            button8.UseVisualStyleBackColor = true;
            history.greek_sxo = false;
            button2.BackColor = SystemColors.Control;
            button2.UseVisualStyleBackColor = true;
            history.chinese_pli = false;
            button9.BackColor = SystemColors.Control;
            button9.UseVisualStyleBackColor = true;
            history.chinese_sxo = false;
            button3.BackColor = SystemColors.Control;
            button3.UseVisualStyleBackColor = true;
            history.italian_pli = false;
            button10.BackColor = SystemColors.Control;
            button10.UseVisualStyleBackColor = true;
            history.italian_sxo = false;
        }

        private void εμφάνισηToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Form1.user == true)
            {
                this.Hide();
                emfanisi emf = new emfanisi();
                emf.ShowDialog();


            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
        }
    }
}
