using System;
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
    public partial class enidrio : Form
    {
        public enidrio()
        {
            InitializeComponent();
            this.Text = "Ενυδρείο";

            if (music.medplay == true)
            {
                button1.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button1.BackgroundImage = Properties.Resources.music_off;
            }

            //history control
            if (history.enidrio_lipsi == true)
            {
                button7.BackColor = Color.LightGreen;
            }
            if(history.enidrio_play == true)
            {
                button4.BackColor = Color.LightGreen;
            }
            if(history.enidrio_sxo == true)
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

        //music control
        private void button1_Click(object sender, EventArgs e)
        {
            // video paused, resume it  
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button1.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button1.BackgroundImage = Properties.Resources.music_on;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                button7.BackColor = Color.LightGreen;
                history.enidrio_lipsi = true;
                string dir = @"../../txt_file/";
                string filename = "enidrio.txt";
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

        private void button4_Click(object sender, EventArgs e)
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
                    button4.BackColor = Color.LightGreen;
                    history.paliapoli_play = true;
                    axWindowsMediaPlayer1.BeginInit();
                    axWindowsMediaPlayer1.URL = @"videos/enidrio.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    //music stopped when playback starts
                    music.SoundPlayerInstance.Stop();
                    music.medplay = false;
                    button1.BackgroundImage = Properties.Resources.music_off;
                }
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
            aksiotheata aks = new aksiotheata();
            aks.ShowDialog();
        }

        //clearing history
        private void button9_Click(object sender, EventArgs e)
        {
            button7.BackColor = SystemColors.Control;
            button7.UseVisualStyleBackColor = true;
            history.enidrio_lipsi = false;
            button4.BackColor = SystemColors.Control;
            button4.UseVisualStyleBackColor = true;
            history.enidrio_play = false;
            button10.BackColor = SystemColors.Control;
            button10.UseVisualStyleBackColor = true;
            history.enidrio_sxo = false;
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
                history.enidrio_sxo = true;
                aksiotheata.aks = 2;
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
