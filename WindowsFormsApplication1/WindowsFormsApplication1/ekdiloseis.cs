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
    
    public partial class ekdiloseis : Form
    {
        public static int ekd = 0;
        public ekdiloseis()
        {
            InitializeComponent();
            this.Text = "Εκδηλώσεις";

            if (music.medplay == true)
            {
                button8.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button8.BackgroundImage = Properties.Resources.music_off;
            }

            //history control
            if (history.jazz_lipsi == true)
            {
                button1.BackColor = Color.LightGreen;
            }
            if(history.jazz_kratisi == true)
            {
                button2.BackColor = Color.LightGreen;
            }
            if(history.jazz_sxolia == true)
            {
                button9.BackColor = Color.LightGreen;
            }
            if(history.ekthesi_lipsi == true)
            {
                button3.BackColor = Color.LightGreen;
            }
            if(history.ekthesi_kratisi == true)
            {
                button4.BackColor = Color.LightGreen;
            }
            if(history.ekthesi_sxolia == true)
            {
                button10.BackColor = Color.LightGreen;
            }            
        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
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
        private void button2_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                button2.BackColor = Color.LightGreen;
                history.jazz_kratisi = true;
                this.Hide();
                kratisi kra = new kratisi();
                kra.from = false;
                kra.ShowDialog();
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                button4.BackColor = Color.LightGreen;
                history.ekthesi_kratisi = true;
                this.Hide();
                kratisi kra = new kratisi();
                kra.from = false;
                kra.ShowDialog();
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
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

        //music control
        private void button8_Click(object sender, EventArgs e)
        {
            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button8.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button8.BackgroundImage = Properties.Resources.music_on;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                button1.BackColor = Color.LightGreen;
                history.jazz_lipsi = true;
                richTextBox1.ResetText();
                string dir = @"../../txt_file/";
                string filename = "ekdilosi1.txt";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                button3.BackColor = Color.LightGreen;
                history.ekthesi_lipsi = true;
                richTextBox1.ResetText();
                string dir = @"../../txt_file/";
                string filename = "ekdilosi2.txt";
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

        private void εμφάνσηToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (Form1.user == true)
            {
                button9.BackColor = Color.LightGreen;
                history.jazz_sxolia = true;
                ekd = 1;
                this.Hide();
                sxolia sxolia = new sxolia();
                sxolia.ShowDialog();
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
                button10.BackColor = Color.LightGreen;
                history.ekthesi_sxolia = true;
                ekd = 2;
                this.Hide();
                sxolia sxolia = new sxolia();
                sxolia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
        }

        //clearing history
        private void button11_Click(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button1.UseVisualStyleBackColor = true;
            history.jazz_lipsi = false;
            button2.BackColor = SystemColors.Control;
            button2.UseVisualStyleBackColor = true;
            history.jazz_kratisi = false;
            button9.BackColor = SystemColors.Control;
            button9.UseVisualStyleBackColor = true;
            history.jazz_sxolia = false;
            button3.BackColor = SystemColors.Control;
            button3.UseVisualStyleBackColor = true;
            history.ekthesi_lipsi = false;
            button4.BackColor = SystemColors.Control;
            button4.UseVisualStyleBackColor = true;
            history.ekthesi_kratisi = false;
            button10.BackColor = SystemColors.Control;
            button10.UseVisualStyleBackColor = true;
            history.ekthesi_sxolia = false;
        }
    }
}
