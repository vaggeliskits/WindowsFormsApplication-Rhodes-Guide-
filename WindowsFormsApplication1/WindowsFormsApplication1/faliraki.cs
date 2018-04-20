﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class faliraki : Form
    {
        public faliraki()
        {
            InitializeComponent();
            this.Text = "Φαληράκι";

            if (music.medplay == true)
            {
                button7.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button7.BackgroundImage = Properties.Resources.music_off;
            }

            //history control
            if (history.faliraki_lipsi == true)
            {
                button8.BackColor = Color.LightGreen;
            }
            if(history.faliraki_play == true)
            {
                button2.BackColor = Color.LightGreen;
            }
            if(history.faliraki_sxo == true)
            {
                button10.BackColor = Color.LightGreen;
            }
        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
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
            // video paused, resume it  
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
            paralies par = new paralies();
            par.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.user == true)
            {
                //axWindowsMediaPlayer1.Ctlcontrols.pause();
                if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPaused)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.user == true)
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    //when video paused, resume it  
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    //otherwise video starts
                    button2.BackColor = Color.LightGreen;
                    history.paliapoli_play = true;
                    axWindowsMediaPlayer1.BeginInit();
                    axWindowsMediaPlayer1.URL = @"videos/faliraki.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    //music stopped when playback starts
                    music.SoundPlayerInstance.Stop();
                    music.medplay = false;
                    button7.BackgroundImage = Properties.Resources.music_off;
                }
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        //music control
        private void button7_Click(object sender, EventArgs e)
        {
            // video paused, resume it  
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button7.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button7.BackgroundImage = Properties.Resources.music_on;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                button8.BackColor = Color.LightGreen;
                history.faliraki_lipsi = true;
                string dir = @"../../txt_file/";
                string filename = "faliraki.txt";
                string fullPath = Path.Combine(dir, filename);
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                string text = File.ReadAllText(fullPath);
                richTextBox1.Text = text;

                SaveFileDialog1.Filter = "Word Document File (*.doc)|*.doc|All files (*.*)|*.*";
                SaveFileDialog1.ShowDialog();
                string path = SaveFileDialog1.FileName;

                try
                {
                    File.WriteAllText(path, richTextBox1.Text);
                    MessageBox.Show("Το αρχείο αποθηκεύτηκε επιτυχώς.");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Το αρχείο δεν αποθηκεύτηκε.");
                }
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
            
        }

        //clearing history
        private void button9_Click(object sender, EventArgs e)
        {
            button8.BackColor = SystemColors.Control;
            button8.UseVisualStyleBackColor = true;
            history.faliraki_lipsi = false;
            button2.BackColor = SystemColors.Control;
            button2.UseVisualStyleBackColor = true;
            history.faliraki_play = false;
            button10.BackColor = SystemColors.Control;
            button10.UseVisualStyleBackColor = true;
            history.faliraki_sxo = false;
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (Form1.user == true)
            {
                history.faliraki_sxo = true;
                paralies.par = 2;
                this.Hide();
                sxolia sxo = new sxolia();
                sxo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
        }
    }
}
