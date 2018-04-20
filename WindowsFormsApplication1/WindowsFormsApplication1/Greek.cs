﻿using System;
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
    public partial class Greek : Form
    {
        public Greek()
        {
            InitializeComponent();
            this.Text = "Σαρρής Ταβέρνα";

            if (music.medplay == true)
            {
                button6.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button6.BackgroundImage = Properties.Resources.music_off;
            }

            //history control
            if (history.greek_xartis == true)
            {
                button1.BackColor = Color.LightGreen;
            }
            if(history.greek_kratisi == true)
            {
                button5.BackColor = Color.LightGreen;
            }
            if(history.greek_sxo == true)
            {
                button8.BackColor = Color.LightGreen;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                button1.BackColor = Color.LightGreen;
                history.greek_xartis = true;
                if (pictureBox4.Visible == true)
                {
                    pictureBox4.Visible = false;
                }
                else
                {
                    pictureBox4.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
           
        }

       private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            estiatoria est = new estiatoria();
            est.ShowDialog();
        }

        //music control
        private void button6_Click(object sender, EventArgs e)
        {
            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button6.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button6.BackgroundImage = Properties.Resources.music_on;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                button5.BackColor = Color.LightGreen;
                history.greek_kratisi = true;
                this.Hide();
                kratisi kra = new kratisi();
                kra.from = true;
                kra.ShowDialog();
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
            
        }

        //clearing history
        private void button7_Click(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button1.UseVisualStyleBackColor = true;
            history.greek_xartis = false;
            button5.BackColor = SystemColors.Control;
            button5.UseVisualStyleBackColor = true;
            history.greek_kratisi = false;
            button8.BackColor = SystemColors.Control;
            button8.UseVisualStyleBackColor = true;
            history.greek_sxo = false;
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
            if (Form1.user == true)
            {
                history.greek_sxo = true;
                estiatoria.est = 1;
                this.Hide();
                sxolia sxolia = new sxolia();
                sxolia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
        }
    }
}
